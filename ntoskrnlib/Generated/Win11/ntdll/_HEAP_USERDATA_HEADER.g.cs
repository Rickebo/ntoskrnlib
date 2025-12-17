#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _HEAP_USERDATA_HEADER
    {
        [FieldOffset(0)]
        public _SINGLE_LIST_ENTRY SFreeListEntry;
        [FieldOffset(0)]
        public IntPtr SubSegment;
        [FieldOffset(8)]
        public IntPtr Reserved;
        [FieldOffset(16)]
        public uint SizeIndexAndPadding;
        [FieldOffset(16)]
        public byte SizeIndex;
        [FieldOffset(17)]
        public byte GuardPagePresent;
        [FieldOffset(18)]
        public ushort PaddingBytes;
        [FieldOffset(20)]
        public uint Signature;
        [FieldOffset(24)]
        public _HEAP_USERDATA_OFFSETS EncodedOffsets;
        [FieldOffset(32)]
        public _RTL_BITMAP_EX BusyBitmap;
        [FieldOffset(48)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public ulong[] BitmapData;
    }
}