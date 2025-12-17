#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _PNP_RESOURCE_CONFLICT_TRACE_CONTEXT
    {
        [FieldOffset(0)]
        public byte ResourceType;
        [FieldOffset(4)]
        public uint AlternativeCount;
        [FieldOffset(8)]
        public IntPtr ResourceRequests;
        [FieldOffset(16)]
        public IntPtr ArbiterInstance;
    }
}