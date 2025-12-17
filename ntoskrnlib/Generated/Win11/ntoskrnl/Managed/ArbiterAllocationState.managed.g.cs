using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ARBITER_ALLOCATION_STATE")]
    public sealed class ArbiterAllocationState : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Start { get => ReadHere<ulong>(nameof(Start)); set => WriteHere(nameof(Start), value); }

        [Offset(8UL)]
        public ulong End { get => ReadHere<ulong>(nameof(End)); set => WriteHere(nameof(End), value); }

        [Offset(16UL)]
        public ulong CurrentMinimum { get => ReadHere<ulong>(nameof(CurrentMinimum)); set => WriteHere(nameof(CurrentMinimum), value); }

        [Offset(24UL)]
        public ulong CurrentMaximum { get => ReadHere<ulong>(nameof(CurrentMaximum)); set => WriteHere(nameof(CurrentMaximum), value); }

        [Offset(32UL)]
        public IntPtr Entry { get => ReadHere<IntPtr>(nameof(Entry)); set => WriteHere(nameof(Entry), value); }

        [Offset(40UL)]
        public IntPtr CurrentAlternative { get => ReadHere<IntPtr>(nameof(CurrentAlternative)); set => WriteHere(nameof(CurrentAlternative), value); }

        [Offset(48UL)]
        public uint AlternativeCount { get => ReadHere<uint>(nameof(AlternativeCount)); set => WriteHere(nameof(AlternativeCount), value); }

        [Offset(56UL)]
        public IntPtr Alternatives { get => ReadHere<IntPtr>(nameof(Alternatives)); set => WriteHere(nameof(Alternatives), value); }

        [Offset(64UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(66UL)]
        public byte RangeAttributes { get => ReadHere<byte>(nameof(RangeAttributes)); set => WriteHere(nameof(RangeAttributes), value); }

        [Offset(67UL)]
        public byte RangeAvailableAttributes { get => ReadHere<byte>(nameof(RangeAvailableAttributes)); set => WriteHere(nameof(RangeAvailableAttributes), value); }

        [Offset(72UL)]
        public ulong WorkSpace { get => ReadHere<ulong>(nameof(WorkSpace)); set => WriteHere(nameof(WorkSpace), value); }

        public ArbiterAllocationState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ArbiterAllocationState>();
        }
    }
}