#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 1728)]
    public partial struct _HEAP_LFH_CONTEXT
    {
        [FieldOffset(0)]
        public IntPtr BackendCtx;
        [FieldOffset(8)]
        public _HEAP_SUBALLOCATOR_CALLBACKS Callbacks;
        [FieldOffset(56)]
        public IntPtr AffinityModArray;
        [FieldOffset(64)]
        public byte MaxAffinity;
        [FieldOffset(65)]
        public byte LockType;
        [FieldOffset(66)]
        public short MemStatsOffset;
        [FieldOffset(68)]
        public _HEAP_LFH_CONFIG Config;
        [FieldOffset(76)]
        public uint TlsSlotIndex;
        [FieldOffset(80)]
        public ulong EncodeKey;
        [FieldOffset(128)]
        public ulong ExtensionLock;
        [FieldOffset(136)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public _SINGLE_LIST_ENTRY[] MetadataList;
        [FieldOffset(192)]
        public _HEAP_LFH_HEAT_MAP HeatMap;
        [FieldOffset(448)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public IntPtr[] Buckets;
        [FieldOffset(1472)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _HEAP_LFH_SLOT_MAP[] SlotMaps;
    }
}