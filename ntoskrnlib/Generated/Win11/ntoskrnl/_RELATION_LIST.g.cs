#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _RELATION_LIST
    {
        [FieldOffset(0)]
        public IntPtr DeviceObjectList;
        [FieldOffset(8)]
        public byte Sorted;
    }
}