#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _ETW_HW_TRACE_EXT_INTERFACE
    {
        [FieldOffset(0)]
        public IntPtr StartProcessorTraceOnEachCore;
        [FieldOffset(8)]
        public IntPtr StopProcessorTraceOnEachCore;
        [FieldOffset(16)]
        public IntPtr LogProcessorTraceOnCurrentCore;
    }
}