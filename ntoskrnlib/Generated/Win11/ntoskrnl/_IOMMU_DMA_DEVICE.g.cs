#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 416)]
    public partial struct _IOMMU_DMA_DEVICE
    {
        [FieldOffset(0)]
        public IntPtr DeviceId;
        [FieldOffset(8)]
        public IntPtr DeviceObject;
        [FieldOffset(16)]
        public int DeviceState;
        [FieldOffset(24)]
        public IntPtr DomainOwner;
        [FieldOffset(32)]
        public _unnamed_tag_ Hypervisor;
        [FieldOffset(32)]
        public _unnamed_tag_ Native;
        [FieldOffset(80)]
        public IntPtr InterfaceCallbackRecord;
        [FieldOffset(88)]
        public byte DpptException;
        [FieldOffset(96)]
        public IntPtr SvmDevice;
        [FieldOffset(104)]
        public IntPtr FaultHandler;
        [FieldOffset(112)]
        public IntPtr FaultContext;
        [FieldOffset(120)]
        public _FAULT_INFORMATION FaultInfo;
        [FieldOffset(176)]
        public _KDPC FaultDpc;
        [FieldOffset(240)]
        public _WORK_QUEUE_ITEM FaultWorkItem;
        [FieldOffset(272)]
        public byte PasidFaultsSuppressed;
        [FieldOffset(273)]
        public byte PasidTaggedDmaEnabled;
        [FieldOffset(274)]
        public byte DefaultPasidEnabled;
        [FieldOffset(280)]
        public _IOMMU_BUS_INTERFACE IommuInterface;
        [FieldOffset(360)]
        public _LIST_ENTRY PasidDevicesList;
        [FieldOffset(376)]
        public _EX_PUSH_LOCK PasidDevicesListLock;
        [FieldOffset(384)]
        public _IOMMU_SVM_CAPABILITIES SvmCapControl;
        [FieldOffset(388)]
        public uint CreationStateInitial;
        [FieldOffset(392)]
        public uint CreationStateCurrent;
        [FieldOffset(400)]
        public _LIST_ENTRY DomainDmaDeviceEntry;
    }
}