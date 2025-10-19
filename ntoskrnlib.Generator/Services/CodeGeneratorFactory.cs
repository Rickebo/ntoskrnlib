using ntoskrnlib.Abstractions;
using ntoskrnlib.Gen;

namespace ntoskrnlib.Services;

internal sealed class CodeGeneratorFactory : ICodeGeneratorFactory
{
    public CodeGenerator Create(TypeInspector inspector, bool flatten, string? @namespace)
        => new CodeGenerator(inspector, flatten, @namespace);
}

