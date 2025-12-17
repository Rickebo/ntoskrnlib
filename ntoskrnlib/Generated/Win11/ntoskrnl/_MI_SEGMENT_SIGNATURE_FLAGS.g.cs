#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _MI_SEGMENT_SIGNATURE_FLAGS
    {
        [FieldOffset(0)]
        public byte ImageSigningLevel;
        [FieldOffset(0)]
        public byte ImageSigningType;
        [FieldOffset(0)]
        public byte Spare;
        [FieldOffset(0)]
        public byte EntireField;
    }
}