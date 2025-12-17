using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KALPC_SECTION")]
    public sealed class KalpcSection : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr SectionObject { get => ReadHere<IntPtr>(nameof(SectionObject)); set => WriteHere(nameof(SectionObject), value); }

        [Offset(8UL)]
        public ulong Size { get => ReadHere<ulong>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(16UL)]
        public IntPtr HandleTable { get => ReadHere<IntPtr>(nameof(HandleTable)); set => WriteHere(nameof(HandleTable), value); }

        [Offset(24UL)]
        public IntPtr SectionHandle { get => ReadHere<IntPtr>(nameof(SectionHandle)); set => WriteHere(nameof(SectionHandle), value); }

        [Offset(32UL)]
        public IntPtr OwnerProcess { get => ReadHere<IntPtr>(nameof(OwnerProcess)); set => WriteHere(nameof(OwnerProcess), value); }

        [Offset(40UL)]
        public IntPtr OwnerPort { get => ReadHere<IntPtr>(nameof(OwnerPort)); set => WriteHere(nameof(OwnerPort), value); }

        [Offset(48UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(52UL)]
        public uint NumberOfRegions { get => ReadHere<uint>(nameof(NumberOfRegions)); set => WriteHere(nameof(NumberOfRegions), value); }

        [Offset(56UL)]
        public ListEntry RegionListHead { get => ReadStructure<ListEntry>(nameof(RegionListHead)); set => WriteStructure(nameof(RegionListHead), value); }

        public KalpcSection(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KalpcSection>();
        }
    }
}