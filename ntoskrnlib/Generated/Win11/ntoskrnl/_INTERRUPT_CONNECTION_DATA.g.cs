#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public partial struct _INTERRUPT_CONNECTION_DATA
    {
        [FieldOffset(0)]
        public uint Count;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _INTERRUPT_VECTOR_DATA[] Vectors;
    }
}