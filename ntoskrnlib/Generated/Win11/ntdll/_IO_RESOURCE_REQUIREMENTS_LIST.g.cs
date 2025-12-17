#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _IO_RESOURCE_REQUIREMENTS_LIST
    {
        [FieldOffset(0)]
        public uint ListSize;
        [FieldOffset(4)]
        public uint InterfaceType;
        [FieldOffset(8)]
        public uint BusNumber;
        [FieldOffset(12)]
        public uint SlotNumber;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public uint[] Reserved;
        [FieldOffset(28)]
        public uint AlternativeLists;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _IO_RESOURCE_LIST[] List;
    }
}