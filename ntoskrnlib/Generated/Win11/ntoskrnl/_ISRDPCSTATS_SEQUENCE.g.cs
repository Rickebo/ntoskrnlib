#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _ISRDPCSTATS_SEQUENCE
    {
        [FieldOffset(0)]
        public uint SequenceNumber;
        [FieldOffset(8)]
        public ulong IsrTime;
        [FieldOffset(16)]
        public ulong IsrCount;
        [FieldOffset(24)]
        public ulong DpcTime;
        [FieldOffset(32)]
        public ulong DpcCount;
    }
}