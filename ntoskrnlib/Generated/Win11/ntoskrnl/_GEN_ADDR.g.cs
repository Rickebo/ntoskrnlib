#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _GEN_ADDR
    {
        [FieldOffset(0)]
        public byte AddressSpaceID;
        [FieldOffset(1)]
        public byte BitWidth;
        [FieldOffset(2)]
        public byte BitOffset;
        [FieldOffset(3)]
        public byte AccessSize;
        [FieldOffset(4)]
        public _LARGE_INTEGER Address;
    }
}