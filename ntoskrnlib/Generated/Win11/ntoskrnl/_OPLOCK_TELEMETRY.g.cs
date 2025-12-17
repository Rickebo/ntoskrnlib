#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _OPLOCK_TELEMETRY
    {
        [FieldOffset(0)]
        public long OplockBreakQpc;
        [FieldOffset(8)]
        public uint TelemetryFlags;
    }
}