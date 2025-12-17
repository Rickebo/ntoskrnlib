#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _EVENT_DATA_DESCRIPTOR
    {
        [FieldOffset(0)]
        public ulong Ptr;
        [FieldOffset(8)]
        public uint Size;
        [FieldOffset(12)]
        public uint Reserved;
        [FieldOffset(12)]
        public byte Type;
        [FieldOffset(13)]
        public byte Reserved1;
        [FieldOffset(14)]
        public ushort Reserved2;
    }
}