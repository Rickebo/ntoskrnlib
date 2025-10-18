using ntoskrnlib.Gen;

namespace ntoskrnlib.Abstractions;

internal interface IDiaInspectorFactory
{
    DiaInspector? TryCreate(string modulePath, string symbolPath);
}

