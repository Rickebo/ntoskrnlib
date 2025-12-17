#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public partial struct _POP_FX_ACTIVE_TIME_ACCOUNTING
    {
        [FieldOffset(0)]
        public ulong Total;
        [FieldOffset(8)]
        public ulong Unattributed;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public ulong[] Buckets;
        [FieldOffset(56)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public ulong[] PerBucket;
    }
}