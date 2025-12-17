#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _PCW_COUNTER_DESCRIPTOR
    {
        [FieldOffset(0)]
        public ushort Id;
        [FieldOffset(2)]
        public ushort StructIndex;
        [FieldOffset(4)]
        public ushort Offset;
        [FieldOffset(6)]
        public ushort Size;
    }
}