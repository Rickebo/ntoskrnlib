#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _COUNTER_READING
    {
        [FieldOffset(0)]
        public uint Type;
        [FieldOffset(4)]
        public uint Index;
        [FieldOffset(8)]
        public ulong Start;
        [FieldOffset(16)]
        public ulong Total;
    }
}