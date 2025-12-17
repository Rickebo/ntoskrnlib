#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct _HEAP_VS_UNUSED_BYTES_INFO
    {
        [FieldOffset(0)]
        public ushort UnusedBytes;
        [FieldOffset(0)]
        public ushort LfhSubsegment;
        [FieldOffset(0)]
        public ushort ExtraPresent;
        [FieldOffset(0)]
        public ushort OneByteUnused;
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] Bytes;
    }
}