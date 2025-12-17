#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct _HEAP_LFH_UNUSED_BYTES_INFO
    {
        [FieldOffset(0)]
        public ushort UnusedBytes;
        [FieldOffset(0)]
        public ushort Spare;
        [FieldOffset(0)]
        public ushort ExtraPresent;
        [FieldOffset(0)]
        public ushort OneByteUnused;
        [FieldOffset(0)]
        public ushort UnusedBytesUShort;
    }
}