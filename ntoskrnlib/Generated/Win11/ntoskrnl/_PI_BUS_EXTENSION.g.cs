#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial struct _PI_BUS_EXTENSION
    {
        [FieldOffset(0)]
        public uint Flags;
        [FieldOffset(4)]
        public byte NumberCSNs;
        [FieldOffset(8)]
        public IntPtr ReadDataPort;
        [FieldOffset(16)]
        public byte DataPortMapped;
        [FieldOffset(24)]
        public IntPtr AddressPort;
        [FieldOffset(32)]
        public byte AddrPortMapped;
        [FieldOffset(40)]
        public IntPtr CommandPort;
        [FieldOffset(48)]
        public byte CmdPortMapped;
        [FieldOffset(52)]
        public uint NextSlotNumber;
        [FieldOffset(56)]
        public _SINGLE_LIST_ENTRY DeviceList;
        [FieldOffset(64)]
        public _SINGLE_LIST_ENTRY CardList;
        [FieldOffset(72)]
        public IntPtr PhysicalBusDevice;
        [FieldOffset(80)]
        public IntPtr FunctionalBusDevice;
        [FieldOffset(88)]
        public IntPtr AttachedDevice;
        [FieldOffset(96)]
        public uint BusNumber;
        [FieldOffset(100)]
        public uint SystemPowerState;
        [FieldOffset(104)]
        public uint DevicePowerState;
    }
}