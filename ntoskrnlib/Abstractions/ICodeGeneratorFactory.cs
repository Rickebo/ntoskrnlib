using ntoskrnlib.Gen;

namespace ntoskrnlib.Abstractions;

internal interface ICodeGeneratorFactory
{
    CodeGenerator Create(TypeInspector inspector, bool flatten, string? @namespace);
}

