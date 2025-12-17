#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _JOB_RATE_CONTROL_HEADER
    {
        [FieldOffset(0)]
        public IntPtr RateControlQuotaReference;
        [FieldOffset(8)]
        public _RTL_BITMAP OverQuotaHistory;
        [FieldOffset(24)]
        public IntPtr BitMapBuffer;
        [FieldOffset(32)]
        public ulong BitMapBufferSize;
    }
}