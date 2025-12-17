#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 176)]
    public partial struct _BUS_HANDLER
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(4)]
        public uint InterfaceType;
        [FieldOffset(8)]
        public uint ConfigurationType;
        [FieldOffset(12)]
        public uint BusNumber;
        [FieldOffset(16)]
        public IntPtr DeviceObject;
        [FieldOffset(24)]
        public IntPtr ParentHandler;
        [FieldOffset(32)]
        public IntPtr BusData;
        [FieldOffset(40)]
        public uint DeviceControlExtensionSize;
        [FieldOffset(48)]
        public IntPtr BusAddresses;
        [FieldOffset(56)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] Reserved;
        [FieldOffset(72)]
        public IntPtr GetBusData;
        [FieldOffset(80)]
        public IntPtr SetBusData;
        [FieldOffset(88)]
        public IntPtr AdjustResourceList;
        [FieldOffset(96)]
        public IntPtr AssignSlotResources;
        [FieldOffset(104)]
        public IntPtr TranslateBusAddress;
        [FieldOffset(112)]
        public IntPtr Spare1;
        [FieldOffset(120)]
        public IntPtr Spare2;
        [FieldOffset(128)]
        public IntPtr Spare3;
        [FieldOffset(136)]
        public IntPtr Spare4;
        [FieldOffset(144)]
        public IntPtr Spare5;
        [FieldOffset(152)]
        public IntPtr Spare6;
        [FieldOffset(160)]
        public IntPtr Spare7;
        [FieldOffset(168)]
        public IntPtr Spare8;
    }
}