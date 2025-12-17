using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VF_TRACKER_STAMP")]
    public sealed class VfTrackerStamp : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Thread { get => ReadHere<IntPtr>(nameof(Thread)); set => WriteHere(nameof(Thread), value); }

        [Offset(8UL)]
        public byte Flags { get => ReadHere<byte>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(9UL)]
        public byte OldIrql { get => ReadHere<byte>(nameof(OldIrql)); set => WriteHere(nameof(OldIrql), value); }

        [Offset(10UL)]
        public byte NewIrql { get => ReadHere<byte>(nameof(NewIrql)); set => WriteHere(nameof(NewIrql), value); }

        [Offset(11UL)]
        public byte Processor { get => ReadHere<byte>(nameof(Processor)); set => WriteHere(nameof(Processor), value); }

        public VfTrackerStamp(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<VfTrackerStamp>();
        }
    }
}