#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _POOL_HEADER
    {
        [FieldOffset(0)]
        public ushort PreviousSize;
        [FieldOffset(0)]
        public ushort PoolIndex;
        [FieldOffset(2)]
        public ushort BlockSize;
        [FieldOffset(2)]
        public ushort PoolType;
        [FieldOffset(0)]
        public uint Ulong1;
        [FieldOffset(4)]
        public uint PoolTag;
        [FieldOffset(8)]
        public IntPtr ProcessBilled;
        [FieldOffset(8)]
        public ushort AllocatorBackTraceIndex;
        [FieldOffset(10)]
        public ushort PoolTagHash;
    }
}