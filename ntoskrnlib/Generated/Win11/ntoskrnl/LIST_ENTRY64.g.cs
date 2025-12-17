#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct LIST_ENTRY64
    {
        [FieldOffset(0)]
        public ulong Flink;
        [FieldOffset(8)]
        public ulong Blink;
    }
}