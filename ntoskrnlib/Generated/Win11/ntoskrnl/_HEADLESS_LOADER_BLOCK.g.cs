#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _HEADLESS_LOADER_BLOCK
    {
        [FieldOffset(0)]
        public byte UsedBiosSettings;
        [FieldOffset(1)]
        public byte DataBits;
        [FieldOffset(2)]
        public byte StopBits;
        [FieldOffset(3)]
        public byte Parity;
        [FieldOffset(4)]
        public uint BaudRate;
        [FieldOffset(8)]
        public uint PortNumber;
        [FieldOffset(16)]
        public IntPtr PortAddress;
        [FieldOffset(24)]
        public ushort PciDeviceId;
        [FieldOffset(26)]
        public ushort PciVendorId;
        [FieldOffset(28)]
        public byte PciBusNumber;
        [FieldOffset(30)]
        public ushort PciBusSegment;
        [FieldOffset(32)]
        public byte PciSlotNumber;
        [FieldOffset(33)]
        public byte PciFunctionNumber;
        [FieldOffset(36)]
        public uint PciFlags;
        [FieldOffset(40)]
        public _GUID SystemGUID;
        [FieldOffset(56)]
        public byte IsMMIODevice;
        [FieldOffset(57)]
        public byte TerminalType;
        [FieldOffset(58)]
        public byte InterfaceType;
        [FieldOffset(59)]
        public byte RegisterBitWidth;
        [FieldOffset(60)]
        public byte RegisterAccessSize;
    }
}