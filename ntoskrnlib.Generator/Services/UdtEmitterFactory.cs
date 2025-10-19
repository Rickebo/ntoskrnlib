using ntoskrnlib.Abstractions;
using ntoskrnlib.Gen;

namespace ntoskrnlib.Services;

internal sealed class UdtEmitterFactory : IUdtEmitterFactory
{
    public UdtEmitter Create(TypeInspector inspector, CodeGenerator generator)
        => new UdtEmitter(inspector, generator);
}

