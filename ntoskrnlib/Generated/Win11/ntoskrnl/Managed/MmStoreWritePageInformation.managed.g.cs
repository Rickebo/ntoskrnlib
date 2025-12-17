using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MM_STORE_WRITE_PAGE_INFORMATION")]
    public sealed class MmStoreWritePageInformation : DynamicStructure
    {
        [Offset(0UL)]
        public int IssueStatus { get => ReadHere<int>(nameof(IssueStatus)); set => WriteHere(nameof(IssueStatus), value); }

        [Offset(4UL)]
        public MmStoreKey StoreKey { get => ReadStructure<MmStoreKey>(nameof(StoreKey)); set => WriteStructure(nameof(StoreKey), value); }

        [Offset(8UL)]
        public MmStoreKeyDescriptor StoreKeyDescriptor { get => ReadStructure<MmStoreKeyDescriptor>(nameof(StoreKeyDescriptor)); set => WriteStructure(nameof(StoreKeyDescriptor), value); }

        [Offset(24UL)]
        public uint WritePageIndex { get => ReadHere<uint>(nameof(WritePageIndex)); set => WriteHere(nameof(WritePageIndex), value); }

        [Offset(32UL)]
        public IntPtr OpaqueStoreContext { get => ReadHere<IntPtr>(nameof(OpaqueStoreContext)); set => WriteHere(nameof(OpaqueStoreContext), value); }

        [Offset(40UL)]
        public IntPtr Mdl { get => ReadHere<IntPtr>(nameof(Mdl)); set => WriteHere(nameof(Mdl), value); }

        [Offset(48UL)]
        public IntPtr TransferContext { get => ReadHere<IntPtr>(nameof(TransferContext)); set => WriteHere(nameof(TransferContext), value); }

        [Offset(56UL)]
        public IntPtr IoStatus { get => ReadHere<IntPtr>(nameof(IoStatus)); set => WriteHere(nameof(IoStatus), value); }

        public MmStoreWritePageInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmStoreWritePageInformation>();
        }
    }
}