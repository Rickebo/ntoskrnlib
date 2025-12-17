#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _MM_STORE_WRITE_PAGE_INFORMATION
    {
        [FieldOffset(0)]
        public int IssueStatus;
        [FieldOffset(4)]
        public _MM_STORE_KEY StoreKey;
        [FieldOffset(8)]
        public _MM_STORE_KEY_DESCRIPTOR StoreKeyDescriptor;
        [FieldOffset(24)]
        public uint WritePageIndex;
        [FieldOffset(32)]
        public IntPtr OpaqueStoreContext;
        [FieldOffset(40)]
        public IntPtr Mdl;
        [FieldOffset(48)]
        public IntPtr TransferContext;
        [FieldOffset(56)]
        public IntPtr IoStatus;
    }
}