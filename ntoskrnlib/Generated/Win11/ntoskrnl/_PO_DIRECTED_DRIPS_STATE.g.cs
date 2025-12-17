#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _PO_DIRECTED_DRIPS_STATE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY QueueLink;
        [FieldOffset(16)]
        public _LIST_ENTRY VisitedQueueLink;
        [FieldOffset(32)]
        public uint Flags;
        [FieldOffset(36)]
        public uint CachedFlags;
        [FieldOffset(40)]
        public uint DeviceUsageCount;
        [FieldOffset(48)]
        public IntPtr Diagnostic;
    }
}