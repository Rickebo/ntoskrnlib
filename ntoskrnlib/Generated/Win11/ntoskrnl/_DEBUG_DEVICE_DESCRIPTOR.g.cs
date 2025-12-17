#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 272)]
    public partial struct _DEBUG_DEVICE_DESCRIPTOR
    {
        [FieldOffset(0)]
        public uint Bus;
        [FieldOffset(4)]
        public uint Slot;
        [FieldOffset(8)]
        public ushort Segment;
        [FieldOffset(10)]
        public ushort VendorID;
        [FieldOffset(12)]
        public ushort DeviceID;
        [FieldOffset(14)]
        public byte BaseClass;
        [FieldOffset(15)]
        public byte SubClass;
        [FieldOffset(16)]
        public byte ProgIf;
        [FieldOffset(17)]
        public byte Flags;
        [FieldOffset(17)]
        public byte DbgHalScratchAllocated;
        [FieldOffset(17)]
        public byte DbgBarsMapped;
        [FieldOffset(17)]
        public byte DbgScratchAllocated;
        [FieldOffset(17)]
        public byte DbgUncachedMemory;
        [FieldOffset(17)]
        public byte DbgSynthetic;
        [FieldOffset(18)]
        public byte Initialized;
        [FieldOffset(19)]
        public byte Configured;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public DEBUG_DEVICE_ADDRESS[] BaseAddress;
        [FieldOffset(168)]
        public DEBUG_MEMORY_REQUIREMENTS Memory;
        [FieldOffset(200)]
        public uint Dbg2TableIndex;
        [FieldOffset(204)]
        public ushort PortType;
        [FieldOffset(206)]
        public ushort PortSubtype;
        [FieldOffset(208)]
        public IntPtr OemData;
        [FieldOffset(216)]
        public uint OemDataLength;
        [FieldOffset(220)]
        public uint NameSpace;
        [FieldOffset(224)]
        public IntPtr NameSpacePath;
        [FieldOffset(232)]
        public uint NameSpacePathLength;
        [FieldOffset(236)]
        public uint TransportType;
        [FieldOffset(240)]
        public _DEBUG_TRANSPORT_DATA TransportData;
        [FieldOffset(256)]
        public _DEBUG_IOMMU_EFI_DATA EfiIoMmuData;
    }
}