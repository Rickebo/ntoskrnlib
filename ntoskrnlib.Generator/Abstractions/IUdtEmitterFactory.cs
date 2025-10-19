using ntoskrnlib.Gen;

namespace ntoskrnlib.Abstractions;

internal interface IUdtEmitterFactory
{
    UdtEmitter Create(TypeInspector inspector, CodeGenerator generator);
}

