#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _SECURITY_DESCRIPTOR
    {
        [FieldOffset(0)]
        public byte Revision;
        [FieldOffset(1)]
        public byte Sbz1;
        [FieldOffset(2)]
        public ushort Control;
        [FieldOffset(8)]
        public IntPtr Owner;
        [FieldOffset(16)]
        public IntPtr Group;
        [FieldOffset(24)]
        public IntPtr Sacl;
        [FieldOffset(32)]
        public IntPtr Dacl;
    }
}