#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _KPRCBFLAG
    {
        [FieldOffset(0)]
        public int PrcbFlags;
        [FieldOffset(0)]
        public uint BamQosLevel;
        [FieldOffset(0)]
        public uint PendingQosUpdate;
        [FieldOffset(0)]
        public uint CacheIsolationEnabled;
        [FieldOffset(0)]
        public uint TracepointActive;
        [FieldOffset(0)]
        public uint LongDpcRunning;
        [FieldOffset(0)]
        public uint PrcbFlagsReserved;
    }
}