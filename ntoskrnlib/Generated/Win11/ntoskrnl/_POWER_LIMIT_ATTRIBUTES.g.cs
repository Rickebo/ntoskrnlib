#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial struct _POWER_LIMIT_ATTRIBUTES
    {
        [FieldOffset(0)]
        public uint Type;
        [FieldOffset(4)]
        public uint DomainId;
        [FieldOffset(8)]
        public uint MaxValue;
        [FieldOffset(12)]
        public uint MinValue;
        [FieldOffset(16)]
        public uint MinTimeParameter;
        [FieldOffset(20)]
        public uint MaxTimeParameter;
        [FieldOffset(24)]
        public uint DefaultACValue;
        [FieldOffset(28)]
        public uint DefaultDCValue;
        [FieldOffset(32)]
        public _unnamed_tag_ Flags;
    }
}