#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct LIST_ENTRY32
    {
        [FieldOffset(0)]
        public uint Flink;
        [FieldOffset(4)]
        public uint Blink;
    }
}