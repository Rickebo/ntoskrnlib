using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VI_TRACK_IRQL")]
    public sealed class ViTrackIrql : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Thread { get => ReadHere<IntPtr>(nameof(Thread)); set => WriteHere(nameof(Thread), value); }

        [Offset(8UL)]
        public byte OldIrql { get => ReadHere<byte>(nameof(OldIrql)); set => WriteHere(nameof(OldIrql), value); }

        [Offset(9UL)]
        public byte NewIrql { get => ReadHere<byte>(nameof(NewIrql)); set => WriteHere(nameof(NewIrql), value); }

        [Offset(10UL)]
        public ushort Processor { get => ReadHere<ushort>(nameof(Processor)); set => WriteHere(nameof(Processor), value); }

        [Offset(12UL)]
        public uint TickCount { get => ReadHere<uint>(nameof(TickCount)); set => WriteHere(nameof(TickCount), value); }

        [Offset(16UL)]
        [Length(5)]
        public DynamicArray StackTrace { get => ReadStructure<DynamicArray>(nameof(StackTrace)); set => WriteStructure(nameof(StackTrace), value); }

        public ViTrackIrql(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ViTrackIrql>();
        }
    }
}