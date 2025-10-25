using Microsoft.Extensions.Logging;
using ntoskrnlib.Abstractions;
using ntoskrnlib.Gen;

namespace ntoskrnlib.Services;

internal sealed class UdtEmitterFactory : IUdtEmitterFactory
{
    private readonly ILogger<UdtEmitter> _logger;

    public UdtEmitterFactory(ILogger<UdtEmitter> logger)
    {
        _logger = logger;
    }

    public UdtEmitter Create(TypeInspector inspector, CodeGenerator generator, DynamicWrapperGenerator? dynamicGenerator, string? @namespace, string? moduleSymbolPrefix)
        => new UdtEmitter(_logger, inspector, generator, dynamicGenerator, @namespace, moduleSymbolPrefix);
}
