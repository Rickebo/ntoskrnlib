using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PTE_TRACKER")]
    public sealed class PteTracker : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public IntPtr Mdl { get => ReadHere<IntPtr>(nameof(Mdl)); set => WriteHere(nameof(Mdl), value); }

        [Offset(24UL)]
        public ulong Count { get => ReadHere<ulong>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(32UL)]
        public IntPtr SystemVa { get => ReadHere<IntPtr>(nameof(SystemVa)); set => WriteHere(nameof(SystemVa), value); }

        [Offset(40UL)]
        public IntPtr StartVa { get => ReadHere<IntPtr>(nameof(StartVa)); set => WriteHere(nameof(StartVa), value); }

        [Offset(48UL)]
        public uint Offset { get => ReadHere<uint>(nameof(Offset)); set => WriteHere(nameof(Offset), value); }

        [Offset(52UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(56UL)]
        public ulong Page { get => ReadHere<ulong>(nameof(Page)); set => WriteHere(nameof(Page), value); }

        [Offset(64UL)]
        public uint IoMapping { get => ReadHere<uint>(nameof(IoMapping)); set => WriteHere(nameof(IoMapping), value); }

        [Offset(64UL)]
        public uint Matched { get => ReadHere<uint>(nameof(Matched)); set => WriteHere(nameof(Matched), value); }

        [Offset(64UL)]
        public uint CacheAttribute { get => ReadHere<uint>(nameof(CacheAttribute)); set => WriteHere(nameof(CacheAttribute), value); }

        [Offset(64UL)]
        public uint GuardPte { get => ReadHere<uint>(nameof(GuardPte)); set => WriteHere(nameof(GuardPte), value); }

        [Offset(64UL)]
        public uint Spare { get => ReadHere<uint>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(72UL)]
        [Length(7)]
        public DynamicArray StackTrace { get => ReadStructure<DynamicArray>(nameof(StackTrace)); set => WriteStructure(nameof(StackTrace), value); }

        public PteTracker(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PteTracker>();
        }
    }
}