#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _ETW_SILO_TRACING_BLOCK
    {
        [FieldOffset(0)]
        public IntPtr ProcessorBuffers;
        [FieldOffset(8)]
        public IntPtr EventsLoggedCount;
        [FieldOffset(16)]
        public IntPtr QpcDelta;
    }
}