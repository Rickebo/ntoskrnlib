#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _DELAY_ACK_FO
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Links;
        [FieldOffset(16)]
        public IntPtr OriginalFileObject;
        [FieldOffset(24)]
        public _OPLOCK_TELEMETRY TelemetryData;
        [FieldOffset(40)]
        public IntPtr AckTimeout;
    }
}