#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MCI_ADDR
    {
        [FieldOffset(0)]
        public uint Address;
        [FieldOffset(4)]
        public uint Reserved;
        [FieldOffset(0)]
        public ulong QuadPart;
    }
}