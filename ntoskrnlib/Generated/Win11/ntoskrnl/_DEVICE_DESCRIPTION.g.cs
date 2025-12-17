#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _DEVICE_DESCRIPTION
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(4)]
        public byte Master;
        [FieldOffset(5)]
        public byte ScatterGather;
        [FieldOffset(6)]
        public byte DemandMode;
        [FieldOffset(7)]
        public byte AutoInitialize;
        [FieldOffset(8)]
        public byte Dma32BitAddresses;
        [FieldOffset(9)]
        public byte IgnoreCount;
        [FieldOffset(10)]
        public byte Reserved1;
        [FieldOffset(11)]
        public byte Dma64BitAddresses;
        [FieldOffset(12)]
        public uint BusNumber;
        [FieldOffset(16)]
        public uint DmaChannel;
        [FieldOffset(20)]
        public uint InterfaceType;
        [FieldOffset(24)]
        public uint DmaWidth;
        [FieldOffset(28)]
        public uint DmaSpeed;
        [FieldOffset(32)]
        public uint MaximumLength;
        [FieldOffset(36)]
        public uint DmaPort;
        [FieldOffset(40)]
        public uint DmaAddressWidth;
        [FieldOffset(44)]
        public uint DmaControllerInstance;
        [FieldOffset(48)]
        public uint DmaRequestLine;
        [FieldOffset(56)]
        public _LARGE_INTEGER DeviceAddress;
    }
}