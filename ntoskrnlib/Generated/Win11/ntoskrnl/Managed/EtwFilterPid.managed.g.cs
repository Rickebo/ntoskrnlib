using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_FILTER_PID")]
    public sealed class EtwFilterPid : DynamicStructure
    {
        [Offset(0UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(4UL)]
        [Length(8)]
        public DynamicArray Pids { get => ReadStructure<DynamicArray>(nameof(Pids)); set => WriteStructure(nameof(Pids), value); }

        public EtwFilterPid(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwFilterPid>();
        }
    }
}