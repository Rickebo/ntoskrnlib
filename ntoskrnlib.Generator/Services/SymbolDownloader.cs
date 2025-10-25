using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection.PortableExecutable;
using System.Runtime.Versioning;
using Microsoft.Extensions.Logging;

namespace ntoskrnlib.Services;

[SupportedOSPlatform("windows")]
internal static class SymbolDownloader
{
    private static readonly HttpClient Http = new()
    {
        Timeout = TimeSpan.FromMinutes(2)
    };

    public static bool EnsureSymbolsAvailable(string modulePath, string symbolPath, ILogger logger)
    {
        if (!OperatingSystem.IsWindows())
            return false;

        if (string.IsNullOrWhiteSpace(modulePath) || !File.Exists(modulePath))
        {
            logger.LogWarning("Module path '{module}' does not exist; skipping symbol prefetch", modulePath);
            return false;
        }

        var signature = TryReadCodeViewInfo(modulePath);
        if (signature == null)
        {
            logger.LogWarning("Module {module} does not contain CodeView debug information; skipping symbol prefetch", modulePath);
            return false;
        }

        var caches = ExtractSymbolCaches(symbolPath).Distinct(StringComparer.OrdinalIgnoreCase).ToList();
        if (caches.Count == 0)
        {
            var defaultCache = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "symbols");
            Directory.CreateDirectory(defaultCache);
            caches.Add(defaultCache);
        }

        var identifiers = BuildIdentifierCandidates(signature).ToList();
        var remoteNames = BuildRemoteNameCandidates(signature).ToList();

        if (IsAlreadyCached(signature, caches, identifiers))
        {
            logger.LogDebug("Symbols for {module} already present in cache", modulePath);
            return true;
        }

        foreach (var cache in caches)
        {
            try
            {
                Directory.CreateDirectory(cache);
            }
            catch (Exception ex)
            {
                logger.LogWarning(ex, "Failed to create symbol cache directory {dir}", cache);
            }
        }

        foreach (var identifier in identifiers)
        {
            foreach (var remoteName in remoteNames)
            {
                if (TryDownload(signature, identifier, remoteName, caches[0], logger))
                {
                    logger.LogInformation("Downloaded symbols for {module} into cache {cache}", modulePath, caches[0]);
                    return true;
                }
            }
        }

        logger.LogWarning("Unable to prefetch symbols for {module}; continuing with configured symbol path only", modulePath);
        return false;
    }

    private static bool TryDownload(PdbSignature signature, string identifier, string remoteName, string cache, ILogger logger)
    {
        var uri = new Uri($"https://msdl.microsoft.com/download/symbols/{signature.FileName}/{identifier}/{remoteName}");
        try
        {
            using var response = Http.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead).GetAwaiter().GetResult();
            if (!response.IsSuccessStatusCode)
            {
                logger.LogDebug("Symbol download attempt returned {status} for {uri}", response.StatusCode, uri);
                return false;
            }

            var destDir = Path.Combine(cache, signature.FileName, identifier);
            Directory.CreateDirectory(destDir);

            var extension = Path.GetExtension(remoteName);
            if (string.Equals(extension, ".pd_", StringComparison.OrdinalIgnoreCase))
            {
                var tempPath = Path.Combine(destDir, remoteName);
                using (var fs = File.Create(tempPath))
                {
                    response.Content.CopyToAsync(fs).GetAwaiter().GetResult();
                }

                var finalPath = Path.Combine(destDir, signature.FileName);
                if (ExpandCompressed(tempPath, finalPath, logger))
                {
                    File.Delete(tempPath);
                    return true;
                }

                File.Delete(tempPath);
                return false;
            }
            else
            {
                var finalPath = Path.Combine(destDir, signature.FileName);
                using (var fs = File.Create(finalPath))
                {
                    response.Content.CopyToAsync(fs).GetAwaiter().GetResult();
                }

                return true;
            }
        }
        catch (Exception ex)
        {
            logger.LogWarning(ex, "Failed to download symbols from {uri}", uri);
            return false;
        }
    }

    private static bool ExpandCompressed(string compressedPath, string finalPath, ILogger logger)
    {
        try
        {
            var psi = new ProcessStartInfo("expand.exe", $"\"{compressedPath}\" \"{finalPath}\"")
            {
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };
            using var proc = Process.Start(psi);
            if (proc == null)
            {
                logger.LogWarning("Failed to start expand.exe for {file}", compressedPath);
                return false;
            }

            var stdout = proc.StandardOutput.ReadToEnd();
            var stderr = proc.StandardError.ReadToEnd();
            proc.WaitForExit();
            if (proc.ExitCode == 0 && File.Exists(finalPath))
            {
                return true;
            }

            logger.LogWarning("expand.exe returned exit code {code} for {file}. StdOut: {out}; StdErr: {err}", proc.ExitCode, compressedPath, stdout.Trim(), stderr.Trim());
            return false;
        }
        catch (Exception ex)
        {
            logger.LogWarning(ex, "expand.exe invocation failed for {file}", compressedPath);
            return false;
        }
    }

    private static bool IsAlreadyCached(PdbSignature signature, IEnumerable<string> caches, IEnumerable<string> identifiers)
    {
        foreach (var cache in caches)
        {
            foreach (var identifier in identifiers)
            {
                var path = Path.Combine(cache, signature.FileName, identifier, signature.FileName);
                if (File.Exists(path))
                    return true;
            }
        }
        return false;
    }

    private static IEnumerable<string> BuildIdentifierCandidates(PdbSignature signature)
    {
        var guid = signature.Guid.ToString("N").ToUpperInvariant();
        yield return guid + signature.Age.ToString();
        yield return guid + signature.Age.ToString("X");
    }

    private static IEnumerable<string> BuildRemoteNameCandidates(PdbSignature signature)
    {
        yield return signature.FileName;
        var compressed = Path.ChangeExtension(signature.FileName, ".pd_");
        if (!string.IsNullOrEmpty(compressed))
            yield return compressed;
    }

    private static IEnumerable<string> ExtractSymbolCaches(string symbolPath)
    {
        if (string.IsNullOrWhiteSpace(symbolPath))
            yield break;

        foreach (var segment in symbolPath.Split(';', StringSplitOptions.RemoveEmptyEntries))
        {
            var trimmed = segment.Trim();
            if (trimmed.StartsWith("srv*", StringComparison.OrdinalIgnoreCase))
            {
                var parts = trimmed.Split('*', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length >= 2 && !string.IsNullOrWhiteSpace(parts[1]))
                    yield return parts[1];
            }
            else if (!trimmed.Contains('*'))
            {
                yield return trimmed;
            }
        }
    }

    private static PdbSignature? TryReadCodeViewInfo(string modulePath)
    {
        try
        {
            using var stream = File.OpenRead(modulePath);
            using var pe = new PEReader(stream);
            foreach (var entry in pe.ReadDebugDirectory())
            {
                if (entry.Type != DebugDirectoryEntryType.CodeView)
                    continue;

                var data = pe.ReadCodeViewDebugDirectoryData(entry);
                var fileName = Path.GetFileName(data.Path);
                if (string.IsNullOrWhiteSpace(fileName))
                    continue;

                return new PdbSignature(fileName, data.Guid, data.Age);
            }
        }
        catch (Exception ex)
        {
            // Only warn once per module
            Console.Error.WriteLine($"[Symbols] Failed to parse PE debug directory for {modulePath}: {ex.Message}");
        }
        return null;
    }

    private sealed record PdbSignature(string FileName, Guid Guid, int Age);
}
