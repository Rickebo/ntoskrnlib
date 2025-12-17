#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _KGDTENTRY64
    {
        [FieldOffset(0)]
        public ushort LimitLow;
        [FieldOffset(2)]
        public ushort BaseLow;
        [FieldOffset(4)]
        public _unnamed_tag_ Bytes;
        [FieldOffset(4)]
        public _unnamed_tag_ Bits;
        [FieldOffset(8)]
        public uint BaseUpper;
        [FieldOffset(12)]
        public uint MustBeZero;
        [FieldOffset(0)]
        public long DataLow;
        [FieldOffset(8)]
        public long DataHigh;
    }
}