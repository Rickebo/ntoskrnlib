using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!PROCESSOR_IDLESTATE_INFO")]
    public sealed class ProcessorIdlestateInfo : DynamicStructure
    {
        [Offset(0UL)]
        public uint TimeCheck { get => ReadHere<uint>(nameof(TimeCheck)); set => WriteHere(nameof(TimeCheck), value); }

        [Offset(4UL)]
        public byte DemotePercent { get => ReadHere<byte>(nameof(DemotePercent)); set => WriteHere(nameof(DemotePercent), value); }

        [Offset(5UL)]
        public byte PromotePercent { get => ReadHere<byte>(nameof(PromotePercent)); set => WriteHere(nameof(PromotePercent), value); }

        [Offset(6UL)]
        [Length(2)]
        public DynamicArray Spare { get => ReadStructure<DynamicArray>(nameof(Spare)); set => WriteStructure(nameof(Spare), value); }

        public ProcessorIdlestateInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcessorIdlestateInfo>();
        }
    }
}