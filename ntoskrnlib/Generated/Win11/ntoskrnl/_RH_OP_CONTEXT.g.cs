#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public partial struct _RH_OP_CONTEXT
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Links;
        [FieldOffset(16)]
        public IntPtr OplockRequestIrp;
        [FieldOffset(24)]
        public IntPtr OplockRequestFileObject;
        [FieldOffset(32)]
        public IntPtr OplockRequestProcess;
        [FieldOffset(40)]
        public IntPtr OplockOwnerThread;
        [FieldOffset(48)]
        public uint Flags;
        [FieldOffset(56)]
        public _LIST_ENTRY AtomicLinks;
        [FieldOffset(72)]
        public _OPLOCK_TELEMETRY TelemetryData;
        [FieldOffset(88)]
        public IntPtr AckTimeout;
    }
}