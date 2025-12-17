using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KALPC_VIEW")]
    public sealed class KalpcView : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ViewListEntry { get => ReadStructure<ListEntry>(nameof(ViewListEntry)); set => WriteStructure(nameof(ViewListEntry), value); }

        [Offset(16UL)]
        public IntPtr Region { get => ReadHere<IntPtr>(nameof(Region)); set => WriteHere(nameof(Region), value); }

        [Offset(24UL)]
        public IntPtr OwnerPort { get => ReadHere<IntPtr>(nameof(OwnerPort)); set => WriteHere(nameof(OwnerPort), value); }

        [Offset(32UL)]
        public IntPtr OwnerProcess { get => ReadHere<IntPtr>(nameof(OwnerProcess)); set => WriteHere(nameof(OwnerProcess), value); }

        [Offset(40UL)]
        public IntPtr Address { get => ReadHere<IntPtr>(nameof(Address)); set => WriteHere(nameof(Address), value); }

        [Offset(48UL)]
        public ulong Size { get => ReadHere<ulong>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(56UL)]
        public IntPtr SecureViewHandle { get => ReadHere<IntPtr>(nameof(SecureViewHandle)); set => WriteHere(nameof(SecureViewHandle), value); }

        [Offset(64UL)]
        public IntPtr WriteAccessHandle { get => ReadHere<IntPtr>(nameof(WriteAccessHandle)); set => WriteHere(nameof(WriteAccessHandle), value); }

        [Offset(72UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(76UL)]
        public uint NumberOfOwnerMessages { get => ReadHere<uint>(nameof(NumberOfOwnerMessages)); set => WriteHere(nameof(NumberOfOwnerMessages), value); }

        [Offset(80UL)]
        public ListEntry ProcessViewListEntry { get => ReadStructure<ListEntry>(nameof(ProcessViewListEntry)); set => WriteStructure(nameof(ProcessViewListEntry), value); }

        public KalpcView(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KalpcView>();
        }
    }
}