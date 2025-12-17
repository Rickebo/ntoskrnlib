#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _DEBUG_TRANSPORT_DATA
    {
        [FieldOffset(0)]
        public uint HwContextSize;
        [FieldOffset(4)]
        public uint SharedVisibleDataSize;
        [FieldOffset(8)]
        public byte UseSerialFraming;
        [FieldOffset(9)]
        public byte ValidUSBCoreId;
        [FieldOffset(10)]
        public byte USBCoreId;
    }
}