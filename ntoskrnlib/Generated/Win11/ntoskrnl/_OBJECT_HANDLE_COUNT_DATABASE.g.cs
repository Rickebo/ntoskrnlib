#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _OBJECT_HANDLE_COUNT_DATABASE
    {
        [FieldOffset(0)]
        public uint CountEntries;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _OBJECT_HANDLE_COUNT_ENTRY[] HandleCountEntries;
    }
}