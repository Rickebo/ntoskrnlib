#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _IO_PRIORITY_INFO
    {
        [FieldOffset(0)]
        public uint Size;
        [FieldOffset(4)]
        public uint ThreadPriority;
        [FieldOffset(8)]
        public uint PagePriority;
        [FieldOffset(12)]
        public uint IoPriority;
    }
}