#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial struct _DEVICE_MANAGE_DATA_SET_ATTRIBUTES
    {
        [FieldOffset(0)]
        public uint Size;
        [FieldOffset(4)]
        public uint Action;
        [FieldOffset(8)]
        public uint Flags;
        [FieldOffset(12)]
        public uint ParameterBlockOffset;
        [FieldOffset(16)]
        public uint ParameterBlockLength;
        [FieldOffset(20)]
        public uint DataSetRangesOffset;
        [FieldOffset(24)]
        public uint DataSetRangesLength;
    }
}