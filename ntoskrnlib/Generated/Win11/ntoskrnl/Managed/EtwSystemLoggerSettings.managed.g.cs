using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_SYSTEM_LOGGER_SETTINGS")]
    public sealed class EtwSystemLoggerSettings : DynamicStructure
    {
        [Offset(0UL)]
        [Length(8)]
        public DynamicArray EtwpSystemLogger { get => ReadStructure<DynamicArray>(nameof(EtwpSystemLogger)); set => WriteStructure(nameof(EtwpSystemLogger), value); }

        [Offset(16UL)]
        public uint EtwpActiveSystemLoggers { get => ReadHere<uint>(nameof(EtwpActiveSystemLoggers)); set => WriteHere(nameof(EtwpActiveSystemLoggers), value); }

        [Offset(20UL)]
        public PerfinfoGroupmask SiloGlobalGroupMask { get => ReadStructure<PerfinfoGroupmask>(nameof(SiloGlobalGroupMask)); set => WriteStructure(nameof(SiloGlobalGroupMask), value); }

        [Offset(52UL)]
        [Length(10)]
        public DynamicArray EtwpGroupMasks { get => ReadStructure<DynamicArray>(nameof(EtwpGroupMasks)); set => WriteStructure(nameof(EtwpGroupMasks), value); }

        public EtwSystemLoggerSettings(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwSystemLoggerSettings>();
        }
    }
}