#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _SCATTER_GATHER_ELEMENT
    {
        [FieldOffset(0)]
        public _LARGE_INTEGER Address;
        [FieldOffset(8)]
        public uint Length;
        [FieldOffset(16)]
        public ulong Reserved;
    }
}