using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!PROCESSOR_PERFSTATE_POLICY")]
    public sealed class ProcessorPerfstatePolicy : DynamicStructure
    {
        [Offset(0UL)]
        public uint Revision { get => ReadHere<uint>(nameof(Revision)); set => WriteHere(nameof(Revision), value); }

        [Offset(4UL)]
        public byte MaxThrottle { get => ReadHere<byte>(nameof(MaxThrottle)); set => WriteHere(nameof(MaxThrottle), value); }

        [Offset(5UL)]
        public byte MinThrottle { get => ReadHere<byte>(nameof(MinThrottle)); set => WriteHere(nameof(MinThrottle), value); }

        [Offset(6UL)]
        public byte BusyAdjThreshold { get => ReadHere<byte>(nameof(BusyAdjThreshold)); set => WriteHere(nameof(BusyAdjThreshold), value); }

        [Offset(7UL)]
        public byte Spare { get => ReadHere<byte>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(7UL)]
        public UnnamedTag Flags { get => ReadStructure<UnnamedTag>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(8UL)]
        public uint TimeCheck { get => ReadHere<uint>(nameof(TimeCheck)); set => WriteHere(nameof(TimeCheck), value); }

        [Offset(12UL)]
        public uint IncreaseTime { get => ReadHere<uint>(nameof(IncreaseTime)); set => WriteHere(nameof(IncreaseTime), value); }

        [Offset(16UL)]
        public uint DecreaseTime { get => ReadHere<uint>(nameof(DecreaseTime)); set => WriteHere(nameof(DecreaseTime), value); }

        [Offset(20UL)]
        public uint IncreasePercent { get => ReadHere<uint>(nameof(IncreasePercent)); set => WriteHere(nameof(IncreasePercent), value); }

        [Offset(24UL)]
        public uint DecreasePercent { get => ReadHere<uint>(nameof(DecreasePercent)); set => WriteHere(nameof(DecreasePercent), value); }

        public ProcessorPerfstatePolicy(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcessorPerfstatePolicy>();
        }
    }
}