#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _SCATTER_GATHER_LIST
    {
        [FieldOffset(0)]
        public uint NumberOfElements;
        [FieldOffset(8)]
        public ulong Reserved;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0)]
        public _SCATTER_GATHER_ELEMENT[] Elements;
    }
}