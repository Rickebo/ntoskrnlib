using System;
using ntoskrnlib.Abstractions;
using ntoskrnlib.Gen;

namespace ntoskrnlib.Services;

internal sealed class DiaInspectorFactory : IDiaInspectorFactory
{
    public DiaInspector? TryCreate(string modulePath, string symbolPath)
    {
        try
        {
            return new DiaInspector(modulePath, symbolPath);
        }
        catch
        {
            return null;
        }
    }
}

