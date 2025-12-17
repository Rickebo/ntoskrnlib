#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _HEAP_LFH_SUBSEGMENT_ENCODED_OFFSETS
    {
        [FieldOffset(0)]
        public ushort BlockSize;
        [FieldOffset(2)]
        public ushort FirstBlockOffset;
        [FieldOffset(0)]
        public uint EncodedData;
    }
}