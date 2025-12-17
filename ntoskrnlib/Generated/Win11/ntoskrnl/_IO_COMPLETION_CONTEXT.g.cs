#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _IO_COMPLETION_CONTEXT
    {
        [FieldOffset(0)]
        public IntPtr Port;
        [FieldOffset(8)]
        public IntPtr Key;
        [FieldOffset(16)]
        public long UsageCount;
    }
}