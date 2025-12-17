#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _KIDTENTRY64
    {
        [FieldOffset(0)]
        public ushort OffsetLow;
        [FieldOffset(2)]
        public ushort Selector;
        [FieldOffset(4)]
        public ushort IstIndex;
        [FieldOffset(4)]
        public ushort Reserved0;
        [FieldOffset(4)]
        public ushort Type;
        [FieldOffset(4)]
        public ushort Dpl;
        [FieldOffset(4)]
        public ushort Present;
        [FieldOffset(6)]
        public ushort OffsetMiddle;
        [FieldOffset(8)]
        public uint OffsetHigh;
        [FieldOffset(12)]
        public uint Reserved1;
        [FieldOffset(0)]
        public ulong Alignment;
    }
}