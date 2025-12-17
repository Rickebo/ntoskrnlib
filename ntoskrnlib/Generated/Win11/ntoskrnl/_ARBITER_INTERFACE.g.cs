#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _ARBITER_INTERFACE
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
        public IntPtr ArbiterHandler;
        [FieldOffset(40)]
        public uint Flags;
    }
}