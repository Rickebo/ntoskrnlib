#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _HEAP_SUBSEGMENT
    {
        [FieldOffset(0)]
        public IntPtr LocalInfo;
        [FieldOffset(8)]
        public IntPtr UserBlocks;
        [FieldOffset(16)]
        public _SLIST_HEADER DelayFreeList;
        [FieldOffset(32)]
        public _INTERLOCK_SEQ AggregateExchg;
        [FieldOffset(36)]
        public ushort BlockSize;
        [FieldOffset(38)]
        public ushort Flags;
        [FieldOffset(40)]
        public ushort BlockCount;
        [FieldOffset(42)]
        public byte SizeIndex;
        [FieldOffset(43)]
        public byte AffinityIndex;
        [FieldOffset(36)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] Alignment;
        [FieldOffset(44)]
        public uint Lock;
        [FieldOffset(48)]
        public _SINGLE_LIST_ENTRY SFreeListEntry;
    }
}