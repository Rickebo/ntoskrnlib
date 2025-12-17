#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public partial struct _HEAP_LFH_BUCKET
    {
        [FieldOffset(0)]
        public _HEAP_LFH_SUBSEGMENT_OWNER State;
        [FieldOffset(56)]
        public ulong TotalBlockCount;
        [FieldOffset(64)]
        public ulong TotalSubsegmentCount;
        [FieldOffset(72)]
        public uint ReciprocalBlockSize;
        [FieldOffset(76)]
        public ushort HotHeatThreshold;
        [FieldOffset(78)]
        public ushort PrivateHeatThreshold;
        [FieldOffset(80)]
        public ulong PrivSlotListLock;
        [FieldOffset(88)]
        public _HEAP_LFH_PTRREF_LIST PrivSlotList;
        [FieldOffset(92)]
        public byte CompactionNeeded;
        [FieldOffset(93)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
        public byte[] Spare;
        [FieldOffset(104)]
        public _HEAP_AFFINITY_MGR AffinityMgr;
    }
}