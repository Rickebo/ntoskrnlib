#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS
    {
        [FieldOffset(0)]
        public uint Primary;
        [FieldOffset(0)]
        public uint ContainmentWarning;
        [FieldOffset(0)]
        public uint Reset;
        [FieldOffset(0)]
        public uint ThresholdExceeded;
        [FieldOffset(0)]
        public uint ResourceNotAvailable;
        [FieldOffset(0)]
        public uint LatentError;
        [FieldOffset(0)]
        public uint Propagated;
        [FieldOffset(0)]
        public uint FruTextByPlugin;
        [FieldOffset(0)]
        public uint Reserved;
        [FieldOffset(0)]
        public uint AsULONG;
    }
}