#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _CM_RESOURCE_LIST
    {
        [FieldOffset(0)]
        public uint Count;
        [FieldOffset(4)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _CM_FULL_RESOURCE_DESCRIPTOR[] List;
    }
}