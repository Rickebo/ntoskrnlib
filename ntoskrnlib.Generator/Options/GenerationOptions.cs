using System.Collections.Generic;

namespace ntoskrnlib.Options;

internal sealed class GenerationOptions
{
    public string Module { get; init; } = string.Empty;
    public List<string> Types { get; init; } = new();
    public bool All { get; init; }
    public string Output { get; init; } = string.Empty;
    public bool Flatten { get; init; }
    public string? ConfigPath { get; init; }
    public bool Deps { get; init; }
    public string? VersionLabel { get; init; }
}
