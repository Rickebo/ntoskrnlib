#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 544)]
    public partial struct _REGISTERED_IOMMU
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public IntPtr InternalData;
        [FieldOffset(24)]
        public uint InternalDataSize;
        [FieldOffset(32)]
        public IntPtr InterruptContext;
        [FieldOffset(40)]
        public byte Irql;
        [FieldOffset(44)]
        public int Gsi;
        [FieldOffset(48)]
        public uint InterruptPolarity;
        [FieldOffset(52)]
        public uint InterruptMode;
        [FieldOffset(56)]
        public _EXT_IOMMU_FUNCTION_TABLE FunctionTable;
        [FieldOffset(208)]
        public _EXT_IOMMU_FUNCTION_TABLE_EXTENDED FunctionTableExtended;
        [FieldOffset(392)]
        public uint Flags;
        [FieldOffset(400)]
        public _IOMMU_PAGE_HANDLING_DATA PageHandling;
        [FieldOffset(440)]
        public uint MaximumDomainIds;
        [FieldOffset(448)]
        public ulong DomainIdBitmapLock;
        [FieldOffset(456)]
        public _RTL_BITMAP DomainIdBitmap;
        [FieldOffset(472)]
        public uint Capabilities;
        [FieldOffset(476)]
        public uint KnownType;
        [FieldOffset(480)]
        public uint PciSegment;
        [FieldOffset(484)]
        public uint PciBus;
        [FieldOffset(488)]
        public _PCI_SLOT_NUMBER PciSlot;
        [FieldOffset(496)]
        public _LARGE_INTEGER MsiAddress;
        [FieldOffset(504)]
        public ulong MsiData;
        [FieldOffset(512)]
        public uint MaximumAsids;
        [FieldOffset(516)]
        public uint Identifier;
        [FieldOffset(520)]
        public _UNICODE_STRING ResourceId;
        [FieldOffset(536)]
        public IntPtr ReservedDevices;
    }
}