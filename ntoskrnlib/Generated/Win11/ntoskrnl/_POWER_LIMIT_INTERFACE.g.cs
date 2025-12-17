#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _POWER_LIMIT_INTERFACE
    {
        [FieldOffset(0)]
        public ushort Size;
        [FieldOffset(2)]
        public ushort Version;
        [FieldOffset(8)]
        public IntPtr Context;
        [FieldOffset(16)]
        public IntPtr InterfaceReference;
        [FieldOffset(24)]
        public IntPtr InterfaceDereference;
        [FieldOffset(32)]
        public uint DomainCount;
        [FieldOffset(40)]
        public IntPtr QueryAttributes;
        [FieldOffset(48)]
        public IntPtr SetPowerLimit;
        [FieldOffset(56)]
        public IntPtr QueryPowerLimit;
    }
}