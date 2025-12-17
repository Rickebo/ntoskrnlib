using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOCK_TRACKER")]
    public sealed class LockTracker : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBalancedNode LockTrackerNode { get => ReadStructure<RtlBalancedNode>(nameof(LockTrackerNode)); set => WriteStructure(nameof(LockTrackerNode), value); }

        [Offset(24UL)]
        public IntPtr Mdl { get => ReadHere<IntPtr>(nameof(Mdl)); set => WriteHere(nameof(Mdl), value); }

        [Offset(32UL)]
        public IntPtr StartVa { get => ReadHere<IntPtr>(nameof(StartVa)); set => WriteHere(nameof(StartVa), value); }

        [Offset(40UL)]
        public ulong Count { get => ReadHere<ulong>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(48UL)]
        public uint Offset { get => ReadHere<uint>(nameof(Offset)); set => WriteHere(nameof(Offset), value); }

        [Offset(52UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(56UL)]
        public uint Who { get => ReadHere<uint>(nameof(Who)); set => WriteHere(nameof(Who), value); }

        [Offset(60UL)]
        public uint Hash { get => ReadHere<uint>(nameof(Hash)); set => WriteHere(nameof(Hash), value); }

        [Offset(64UL)]
        public ulong Page { get => ReadHere<ulong>(nameof(Page)); set => WriteHere(nameof(Page), value); }

        [Offset(72UL)]
        [Length(14)]
        public DynamicArray StackTrace { get => ReadStructure<DynamicArray>(nameof(StackTrace)); set => WriteStructure(nameof(StackTrace), value); }

        [Offset(184UL)]
        public IntPtr Process { get => ReadHere<IntPtr>(nameof(Process)); set => WriteHere(nameof(Process), value); }

        public LockTracker(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LockTracker>();
        }
    }
}