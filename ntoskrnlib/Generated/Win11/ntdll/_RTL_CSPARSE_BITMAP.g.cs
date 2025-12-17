#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _RTL_CSPARSE_BITMAP
    {
        [FieldOffset(0)]
        public IntPtr CommitBitmap;
        [FieldOffset(8)]
        public IntPtr UserBitmap;
        [FieldOffset(16)]
        public ulong BitCount;
        [FieldOffset(24)]
        public ulong BitmapLock;
        [FieldOffset(32)]
        public ulong DecommitPageIndex;
        [FieldOffset(40)]
        public ulong RtlpCSparseBitmapWakeLock;
        [FieldOffset(48)]
        public byte LockType;
        [FieldOffset(49)]
        public byte AddressSpace;
        [FieldOffset(50)]
        public byte MemType;
        [FieldOffset(51)]
        public byte AllocAlignment;
        [FieldOffset(52)]
        public uint CommitDirectoryMaxSize;
        [FieldOffset(56)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public ulong[] CommitDirectory;
    }
}