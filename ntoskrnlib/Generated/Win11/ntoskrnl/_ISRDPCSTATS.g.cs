#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public partial struct _ISRDPCSTATS
    {
        [FieldOffset(0)]
        public ulong IsrTime;
        [FieldOffset(8)]
        public ulong IsrTimeStart;
        [FieldOffset(16)]
        public ulong IsrCount;
        [FieldOffset(24)]
        public ulong DpcTime;
        [FieldOffset(32)]
        public ulong DpcTimeStart;
        [FieldOffset(40)]
        public ulong DpcCount;
        [FieldOffset(48)]
        public byte IsrActive;
        [FieldOffset(49)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public byte[] Reserved;
        [FieldOffset(56)]
        public _ISRDPCSTATS_SEQUENCE DpcWatchdog;
    }
}