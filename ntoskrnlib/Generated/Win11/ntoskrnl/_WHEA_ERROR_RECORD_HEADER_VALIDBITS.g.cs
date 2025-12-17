#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _WHEA_ERROR_RECORD_HEADER_VALIDBITS
    {
        [FieldOffset(0)]
        public uint PlatformId;
        [FieldOffset(0)]
        public uint Timestamp;
        [FieldOffset(0)]
        public uint PartitionId;
        [FieldOffset(0)]
        public uint Reserved;
        [FieldOffset(0)]
        public uint AsULONG;
    }
}