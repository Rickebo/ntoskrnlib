using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_DEVICE")]
    public sealed class IommuDmaDevice : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DeviceId { get => ReadHere<IntPtr>(nameof(DeviceId)); set => WriteHere(nameof(DeviceId), value); }

        [Offset(8UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(16UL)]
        public int DeviceState { get => ReadHere<int>(nameof(DeviceState)); set => WriteHere(nameof(DeviceState), value); }

        [Offset(24UL)]
        public IntPtr DomainOwner { get => ReadHere<IntPtr>(nameof(DomainOwner)); set => WriteHere(nameof(DomainOwner), value); }

        [Offset(32UL)]
        public UnnamedTag Hypervisor { get => ReadStructure<UnnamedTag>(nameof(Hypervisor)); set => WriteStructure(nameof(Hypervisor), value); }

        [Offset(32UL)]
        public UnnamedTag Native { get => ReadStructure<UnnamedTag>(nameof(Native)); set => WriteStructure(nameof(Native), value); }

        [Offset(80UL)]
        public IntPtr InterfaceCallbackRecord { get => ReadHere<IntPtr>(nameof(InterfaceCallbackRecord)); set => WriteHere(nameof(InterfaceCallbackRecord), value); }

        [Offset(88UL)]
        public byte DpptException { get => ReadHere<byte>(nameof(DpptException)); set => WriteHere(nameof(DpptException), value); }

        [Offset(96UL)]
        public IntPtr SvmDevice { get => ReadHere<IntPtr>(nameof(SvmDevice)); set => WriteHere(nameof(SvmDevice), value); }

        [Offset(104UL)]
        public IntPtr FaultHandler { get => ReadHere<IntPtr>(nameof(FaultHandler)); set => WriteHere(nameof(FaultHandler), value); }

        [Offset(112UL)]
        public IntPtr FaultContext { get => ReadHere<IntPtr>(nameof(FaultContext)); set => WriteHere(nameof(FaultContext), value); }

        [Offset(120UL)]
        public FaultInformation FaultInfo { get => ReadStructure<FaultInformation>(nameof(FaultInfo)); set => WriteStructure(nameof(FaultInfo), value); }

        [Offset(176UL)]
        public Kdpc FaultDpc { get => ReadStructure<Kdpc>(nameof(FaultDpc)); set => WriteStructure(nameof(FaultDpc), value); }

        [Offset(240UL)]
        public WorkQueueItem FaultWorkItem { get => ReadStructure<WorkQueueItem>(nameof(FaultWorkItem)); set => WriteStructure(nameof(FaultWorkItem), value); }

        [Offset(272UL)]
        public byte PasidFaultsSuppressed { get => ReadHere<byte>(nameof(PasidFaultsSuppressed)); set => WriteHere(nameof(PasidFaultsSuppressed), value); }

        [Offset(273UL)]
        public byte PasidTaggedDmaEnabled { get => ReadHere<byte>(nameof(PasidTaggedDmaEnabled)); set => WriteHere(nameof(PasidTaggedDmaEnabled), value); }

        [Offset(274UL)]
        public byte DefaultPasidEnabled { get => ReadHere<byte>(nameof(DefaultPasidEnabled)); set => WriteHere(nameof(DefaultPasidEnabled), value); }

        [Offset(280UL)]
        public IommuBusInterface IommuInterface { get => ReadStructure<IommuBusInterface>(nameof(IommuInterface)); set => WriteStructure(nameof(IommuInterface), value); }

        [Offset(360UL)]
        public ListEntry PasidDevicesList { get => ReadStructure<ListEntry>(nameof(PasidDevicesList)); set => WriteStructure(nameof(PasidDevicesList), value); }

        [Offset(376UL)]
        public ExPushLock PasidDevicesListLock { get => ReadStructure<ExPushLock>(nameof(PasidDevicesListLock)); set => WriteStructure(nameof(PasidDevicesListLock), value); }

        [Offset(384UL)]
        public IommuSvmCapabilities SvmCapControl { get => ReadStructure<IommuSvmCapabilities>(nameof(SvmCapControl)); set => WriteStructure(nameof(SvmCapControl), value); }

        [Offset(388UL)]
        public uint CreationStateInitial { get => ReadHere<uint>(nameof(CreationStateInitial)); set => WriteHere(nameof(CreationStateInitial), value); }

        [Offset(392UL)]
        public uint CreationStateCurrent { get => ReadHere<uint>(nameof(CreationStateCurrent)); set => WriteHere(nameof(CreationStateCurrent), value); }

        [Offset(400UL)]
        public ListEntry DomainDmaDeviceEntry { get => ReadStructure<ListEntry>(nameof(DomainDmaDeviceEntry)); set => WriteStructure(nameof(DomainDmaDeviceEntry), value); }

        public IommuDmaDevice(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuDmaDevice>();
        }
    }
}