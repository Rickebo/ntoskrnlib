#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 192)]
    public partial struct _HEAP_LOCAL_SEGMENT_INFO
    {
        [FieldOffset(0)]
        public IntPtr LocalData;
        [FieldOffset(8)]
        public IntPtr ActiveSubsegment;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public IntPtr[] CachedItems;
        [FieldOffset(144)]
        public _SLIST_HEADER SListHeader;
        [FieldOffset(160)]
        public _HEAP_BUCKET_COUNTERS Counters;
        [FieldOffset(168)]
        public uint LastOpSequence;
        [FieldOffset(172)]
        public ushort BucketIndex;
        [FieldOffset(174)]
        public ushort LastUsed;
        [FieldOffset(176)]
        public ushort NoThrashCount;
    }
}