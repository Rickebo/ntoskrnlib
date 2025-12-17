using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_BOOT_CONFIG")]
    public sealed class EtwBootConfig : DynamicStructure
    {
        [Offset(0UL)]
        public uint MaxLoggers { get => ReadHere<uint>(nameof(MaxLoggers)); set => WriteHere(nameof(MaxLoggers), value); }

        [Offset(8UL)]
        public ListEntry BootLoggersList { get => ReadStructure<ListEntry>(nameof(BootLoggersList)); set => WriteStructure(nameof(BootLoggersList), value); }

        public EtwBootConfig(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwBootConfig>();
        }
    }
}