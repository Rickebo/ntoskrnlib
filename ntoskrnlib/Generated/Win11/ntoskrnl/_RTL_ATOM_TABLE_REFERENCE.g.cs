#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _RTL_ATOM_TABLE_REFERENCE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY LowBoxList;
        [FieldOffset(16)]
        public uint LowBoxID;
        [FieldOffset(20)]
        public ushort ReferenceCount;
        [FieldOffset(22)]
        public ushort Flags;
    }
}