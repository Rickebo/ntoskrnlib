using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KALPC_REGION")]
    public sealed class KalpcRegion : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry RegionListEntry { get => ReadStructure<ListEntry>(nameof(RegionListEntry)); set => WriteStructure(nameof(RegionListEntry), value); }

        [Offset(16UL)]
        public IntPtr Section { get => ReadHere<IntPtr>(nameof(Section)); set => WriteHere(nameof(Section), value); }

        [Offset(24UL)]
        public ulong Offset { get => ReadHere<ulong>(nameof(Offset)); set => WriteHere(nameof(Offset), value); }

        [Offset(32UL)]
        public ulong Size { get => ReadHere<ulong>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(40UL)]
        public ulong ViewSize { get => ReadHere<ulong>(nameof(ViewSize)); set => WriteHere(nameof(ViewSize), value); }

        [Offset(48UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(52UL)]
        public uint NumberOfViews { get => ReadHere<uint>(nameof(NumberOfViews)); set => WriteHere(nameof(NumberOfViews), value); }

        [Offset(56UL)]
        public ListEntry ViewListHead { get => ReadStructure<ListEntry>(nameof(ViewListHead)); set => WriteStructure(nameof(ViewListHead), value); }

        [Offset(72UL)]
        public IntPtr ReadOnlyView { get => ReadHere<IntPtr>(nameof(ReadOnlyView)); set => WriteHere(nameof(ReadOnlyView), value); }

        [Offset(80UL)]
        public IntPtr ReadWriteView { get => ReadHere<IntPtr>(nameof(ReadWriteView)); set => WriteHere(nameof(ReadWriteView), value); }

        public KalpcRegion(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KalpcRegion>();
        }
    }
}