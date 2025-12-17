#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _POOL_TRACKER_TABLE
    {
        [FieldOffset(0)]
        public int Key;
        [FieldOffset(8)]
        public ulong NonPagedBytes;
        [FieldOffset(16)]
        public ulong NonPagedAllocs;
        [FieldOffset(24)]
        public ulong NonPagedFrees;
        [FieldOffset(32)]
        public ulong PagedBytes;
        [FieldOffset(40)]
        public ulong PagedAllocs;
        [FieldOffset(48)]
        public ulong PagedFrees;
        [FieldOffset(56)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public long[] AvailableLimit;
        [FieldOffset(72)]
        public IntPtr LimitInfo;
    }
}