Write-Host "Analyzing managed class compilation errors..." -ForegroundColor Cyan

# Build and capture errors
$output = dotnet build ntoskrnlib\ntoskrnlib.csproj -c Release -p:SkipGenerateTypes=true 2>&1

# Extract error lines
$errors = $output | Where-Object { $_ -match "error CS\d+:" }

Write-Host "`nTotal errors: $($errors.Count)" -ForegroundColor Red

# Get unique files with errors
$errorFiles = $errors | ForEach-Object {
    if ($_ -match "\\([^\\]+\.managed\.g\.cs)") {
        $matches[1]
    }
} | Select-Object -Unique

Write-Host "Files with errors: $($errorFiles.Count)" -ForegroundColor Yellow

# Sample some problematic lines
Write-Host "`nSample problematic generated code:" -ForegroundColor Yellow
$sampleFiles = @(
    "ntoskrnlib\Generated\Win25H2\ntoskrnl\Managed\AdapterObject.managed.g.cs",
    "ntoskrnlib\Generated\Win25H2\ntoskrnl\Managed\DeviceMap.managed.g.cs"
)

foreach ($file in $sampleFiles) {
    if (Test-Path $file) {
        Write-Host "`n--- $($file.Split('\')[-1]) ---" -ForegroundColor Cyan
        $content = Get-Content $file
        # Find lines with void[] or similar issues
        $content | Select-String -Pattern "void\[\]|^\s+public \w+\[\]" | ForEach-Object {
            Write-Host "  Line $($_.LineNumber): $($_.Line.Trim())"
        }
    }
}

# Analyze error patterns
Write-Host "`nError patterns:" -ForegroundColor Yellow
$errorTypes = @{}
$errors | ForEach-Object {
    if ($_ -match "error (CS\d+):") {
        $code = $matches[1]
        if (-not $errorTypes.ContainsKey($code)) {
            $errorTypes[$code] = 0
        }
        $errorTypes[$code]++
    }
}

$errorTypes.GetEnumerator() | Sort-Object Value -Descending | ForEach-Object {
    Write-Host "  $($_.Key): $($_.Value) occurrences"
}
