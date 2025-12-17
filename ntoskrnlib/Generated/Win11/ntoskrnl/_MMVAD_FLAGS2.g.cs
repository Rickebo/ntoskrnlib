#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MMVAD_FLAGS2
    {
        [FieldOffset(0)]
        public uint Large;
        [FieldOffset(0)]
        public uint TrimBehind;
        [FieldOffset(0)]
        public uint Inherit;
        [FieldOffset(0)]
        public uint NoValidationNeeded;
        [FieldOffset(0)]
        public uint PrivateDemandZero;
        [FieldOffset(0)]
        public uint ImageMappingExtended;
        [FieldOffset(0)]
        public uint Spare;
        [FieldOffset(0)]
        public uint LongFlags;
    }
}