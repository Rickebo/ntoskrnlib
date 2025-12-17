#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _LIST_ENTRY
    {
        [FieldOffset(0)]
        public IntPtr Flink;
        [FieldOffset(8)]
        public IntPtr Blink;
    }
}