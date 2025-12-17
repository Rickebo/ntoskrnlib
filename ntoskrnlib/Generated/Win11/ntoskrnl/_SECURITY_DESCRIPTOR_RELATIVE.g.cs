#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct _SECURITY_DESCRIPTOR_RELATIVE
    {
        [FieldOffset(0)]
        public byte Revision;
        [FieldOffset(1)]
        public byte Sbz1;
        [FieldOffset(2)]
        public ushort Control;
        [FieldOffset(4)]
        public uint Owner;
        [FieldOffset(8)]
        public uint Group;
        [FieldOffset(12)]
        public uint Sacl;
        [FieldOffset(16)]
        public uint Dacl;
    }
}