#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _HEAP_TAG_ENTRY
    {
        [FieldOffset(0)]
        public uint Allocs;
        [FieldOffset(4)]
        public uint Frees;
        [FieldOffset(8)]
        public ulong Size;
        [FieldOffset(16)]
        public ushort TagIndex;
        [FieldOffset(18)]
        public ushort CreatorBackTraceIndex;
        [FieldOffset(20)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public short[] TagName;
    }
}