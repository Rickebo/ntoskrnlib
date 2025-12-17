#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _HEAP_VAMGR_RANGE
    {
        [FieldOffset(0)]
        public _RTL_BALANCED_NODE RbNode;
        [FieldOffset(0)]
        public _SINGLE_LIST_ENTRY Next;
        [FieldOffset(0)]
        public byte Allocated;
        [FieldOffset(0)]
        public byte Internal;
        [FieldOffset(0)]
        public byte Standalone;
        [FieldOffset(0)]
        public byte Spare0;
        [FieldOffset(1)]
        public byte AllocatorIndex;
        [FieldOffset(2)]
        public ushort CommitBitmap;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] OwnerCtx;
        [FieldOffset(24)]
        public ulong SizeInChunks;
        [FieldOffset(24)]
        public ushort ChunkCount;
        [FieldOffset(26)]
        public ushort PrevChunkCount;
        [FieldOffset(24)]
        public ulong Signature;
    }
}