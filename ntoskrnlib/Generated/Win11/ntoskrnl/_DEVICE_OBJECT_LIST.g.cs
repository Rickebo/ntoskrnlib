#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _DEVICE_OBJECT_LIST
    {
        [FieldOffset(0)]
        public uint Count;
        [FieldOffset(4)]
        public uint MaxCount;
        [FieldOffset(8)]
        public uint TagCount;
        [FieldOffset(12)]
        public uint OperationCode;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _DEVICE_OBJECT_LIST_ENTRY[] Devices;
    }
}