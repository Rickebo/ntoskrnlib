#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _RTL_ATOM_TABLE_ENTRY
    {
        [FieldOffset(0)]
        public IntPtr HashLink;
        [FieldOffset(8)]
        public ushort HandleIndex;
        [FieldOffset(10)]
        public ushort Atom;
        [FieldOffset(16)]
        public _RTL_ATOM_TABLE_REFERENCE Reference;
        [FieldOffset(40)]
        public byte NameLength;
        [FieldOffset(42)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public short[] Name;
    }
}