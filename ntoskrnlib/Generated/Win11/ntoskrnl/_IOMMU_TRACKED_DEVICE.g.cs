#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4184)]
    public partial struct _IOMMU_TRACKED_DEVICE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public ulong Lock;
        [FieldOffset(24)]
        public IntPtr Iommu;
        [FieldOffset(32)]
        public uint IommuCapabilities;
        [FieldOffset(36)]
        public uint ReferenceCount;
        [FieldOffset(40)]
        public ulong SourceId;
        [FieldOffset(48)]
        public _IOMMU_SVM_CAPABILITIES Capabilities;
        [FieldOffset(52)]
        public uint Flags;
        [FieldOffset(56)]
        public _LIST_ENTRY ActiveDeviceListHead;
        [FieldOffset(72)]
        public IntPtr DmaDevice;
        [FieldOffset(80)]
        public uint LastGroupFaultSequenceNumber;
        [FieldOffset(88)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
        public _GROUP_FAULT_REFERENCE[] GroupFaultReferences;
    }
}