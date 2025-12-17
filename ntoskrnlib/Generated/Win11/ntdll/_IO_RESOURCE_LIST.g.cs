#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _IO_RESOURCE_LIST
    {
        [FieldOffset(0)]
        public ushort Version;
        [FieldOffset(2)]
        public ushort Revision;
        [FieldOffset(4)]
        public uint Count;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _IO_RESOURCE_DESCRIPTOR[] Descriptors;
    }
}