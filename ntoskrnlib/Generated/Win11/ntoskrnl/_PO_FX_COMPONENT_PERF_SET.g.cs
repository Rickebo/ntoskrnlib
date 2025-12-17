#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _PO_FX_COMPONENT_PERF_SET
    {
        [FieldOffset(0)]
        public _UNICODE_STRING Name;
        [FieldOffset(16)]
        public ulong Flags;
        [FieldOffset(24)]
        public uint Unit;
        [FieldOffset(28)]
        public uint Type;
        [FieldOffset(32)]
        public _unnamed_tag_ Discrete;
        [FieldOffset(32)]
        public _unnamed_tag_ Range;
    }
}