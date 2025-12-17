#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public partial struct _HEAP_VS_CONTEXT
    {
        [FieldOffset(0)]
        public ushort SlotMapRef;
        [FieldOffset(2)]
        public byte AffinityMask;
        [FieldOffset(3)]
        public byte LockType;
        [FieldOffset(4)]
        public _RTL_HP_VS_CONFIG Config;
        [FieldOffset(5)]
        public byte EliminatePointers;
        [FieldOffset(6)]
        public short MemStatsOffset;
        [FieldOffset(8)]
        public IntPtr BackendCtx;
        [FieldOffset(16)]
        public _HEAP_SUBALLOCATOR_CALLBACKS Callbacks;
        [FieldOffset(64)]
        public _HEAP_AFFINITY_MGR AffinityMgr;
        [FieldOffset(80)]
        public ulong TotalCommittedUnits;
        [FieldOffset(88)]
        public ulong FreeCommittedUnits;
    }
}