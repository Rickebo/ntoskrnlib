using ntoskrnlib.Abstractions;
using ntoskrnlib.Gen;

namespace ntoskrnlib.Services;

internal sealed class UdtEmitterFactory : IUdtEmitterFactory
{
    public UdtEmitter Create(TypeInspector inspector, CodeGenerator generator, DynamicWrapperGenerator? dynamicGenerator, string? @namespace, string? moduleSymbolPrefix)
        => new UdtEmitter(inspector, generator, dynamicGenerator, @namespace, moduleSymbolPrefix);
}
