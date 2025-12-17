#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 314176)]
    public partial struct _MI_NODE_SLAB_IDENTITY_STATE
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 65)]
        public byte[] SlabIdentityStandbyListCaches;
        [FieldOffset(266240)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 65)]
        public byte[] SlabIdentityStandbyPageLists;
        [FieldOffset(312000)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] SlabIdentityHints;
        [FieldOffset(313024)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 65)]
        public _LIST_ENTRY[] SlabIdentityLists;
        [FieldOffset(314064)]
        public _RTL_BITMAP SlabIdentityEmptyEntryBitmap;
        [FieldOffset(314080)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public uint[] SlabIdentityEmptyEntryBitmapBuffer;
        [FieldOffset(314096)]
        public _RTL_BITMAP SlabIdentityStandbyExistsBitmap;
        [FieldOffset(314112)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public uint[] SlabIdentityStandbyExistsBitmapBuffer;
    }
}