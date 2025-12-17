using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ADAPTER_OBJECT")]
    public sealed class AdapterObject : DynamicStructure
    {
        [Offset(0UL)]
        public HalpDmaAdapterObject BaseAdapterObject { get => ReadStructure<HalpDmaAdapterObject>(nameof(BaseAdapterObject)); set => WriteStructure(nameof(BaseAdapterObject), value); }

        [Offset(160UL)]
        public IntPtr MasterAdapter { get => ReadHere<IntPtr>(nameof(MasterAdapter)); set => WriteHere(nameof(MasterAdapter), value); }

        [Offset(168UL)]
        public ListEntry WaitQueueEntry { get => ReadStructure<ListEntry>(nameof(WaitQueueEntry)); set => WriteStructure(nameof(WaitQueueEntry), value); }

        [Offset(184UL)]
        public KdeviceQueue ChannelWaitQueue { get => ReadStructure<KdeviceQueue>(nameof(ChannelWaitQueue)); set => WriteStructure(nameof(ChannelWaitQueue), value); }

        [Offset(184UL)]
        public ulong ResourceWaitLock { get => ReadHere<ulong>(nameof(ResourceWaitLock)); set => WriteHere(nameof(ResourceWaitLock), value); }

        [Offset(192UL)]
        public ListEntry ResourceWaitQueue { get => ReadStructure<ListEntry>(nameof(ResourceWaitQueue)); set => WriteStructure(nameof(ResourceWaitQueue), value); }

        [Offset(208UL)]
        public ListEntry ChannelResourceWaitQueue { get => ReadStructure<ListEntry>(nameof(ChannelResourceWaitQueue)); set => WriteStructure(nameof(ChannelResourceWaitQueue), value); }

        [Offset(224UL)]
        public byte ResourceQueueBusy { get => ReadHere<byte>(nameof(ResourceQueueBusy)); set => WriteHere(nameof(ResourceQueueBusy), value); }

        [Offset(232UL)]
        public uint MapRegistersPerChannel { get => ReadHere<uint>(nameof(MapRegistersPerChannel)); set => WriteHere(nameof(MapRegistersPerChannel), value); }

        [Offset(240UL)]
        public IntPtr MapRegisterBase { get => ReadHere<IntPtr>(nameof(MapRegisterBase)); set => WriteHere(nameof(MapRegisterBase), value); }

        [Offset(248UL)]
        public uint NumberOfMapRegisters { get => ReadHere<uint>(nameof(NumberOfMapRegisters)); set => WriteHere(nameof(NumberOfMapRegisters), value); }

        [Offset(252UL)]
        public uint MaxTransferLength { get => ReadHere<uint>(nameof(MaxTransferLength)); set => WriteHere(nameof(MaxTransferLength), value); }

        [Offset(256UL)]
        [Length(2)]
        public DynamicArray CrashDumpRegisterBase { get => ReadStructure<DynamicArray>(nameof(CrashDumpRegisterBase)); set => WriteStructure(nameof(CrashDumpRegisterBase), value); }

        [Offset(272UL)]
        [Length(2)]
        public DynamicArray NumberOfCrashDumpRegisters { get => ReadStructure<DynamicArray>(nameof(NumberOfCrashDumpRegisters)); set => WriteStructure(nameof(NumberOfCrashDumpRegisters), value); }

        [Offset(280UL)]
        [Length(2)]
        public DynamicArray CrashDumpRegisterRefCount { get => ReadStructure<DynamicArray>(nameof(CrashDumpRegisterRefCount)); set => WriteStructure(nameof(CrashDumpRegisterRefCount), value); }

        [Offset(288UL)]
        public ListEntry AdapterCrashDumpList { get => ReadStructure<ListEntry>(nameof(AdapterCrashDumpList)); set => WriteStructure(nameof(AdapterCrashDumpList), value); }

        [Offset(304UL)]
        public IntPtr MapRegisterMdl { get => ReadHere<IntPtr>(nameof(MapRegisterMdl)); set => WriteHere(nameof(MapRegisterMdl), value); }

        [Offset(312UL)]
        public ulong MapRegisterMdlLock { get => ReadHere<ulong>(nameof(MapRegisterMdlLock)); set => WriteHere(nameof(MapRegisterMdlLock), value); }

        [Offset(320UL)]
        public ExPushLock ExpiredLock { get => ReadStructure<ExPushLock>(nameof(ExpiredLock)); set => WriteStructure(nameof(ExpiredLock), value); }

        [Offset(328UL)]
        public IntPtr AllocationHandle { get => ReadHere<IntPtr>(nameof(AllocationHandle)); set => WriteHere(nameof(AllocationHandle), value); }

        [Offset(336UL)]
        public IntPtr VirtualAddress { get => ReadHere<IntPtr>(nameof(VirtualAddress)); set => WriteHere(nameof(VirtualAddress), value); }

        [Offset(344UL)]
        public byte IsAllocationMdlBased { get => ReadHere<byte>(nameof(IsAllocationMdlBased)); set => WriteHere(nameof(IsAllocationMdlBased), value); }

        [Offset(345UL)]
        public byte NoLocalPool { get => ReadHere<byte>(nameof(NoLocalPool)); set => WriteHere(nameof(NoLocalPool), value); }

        [Offset(346UL)]
        public byte ExpiredFlag { get => ReadHere<byte>(nameof(ExpiredFlag)); set => WriteHere(nameof(ExpiredFlag), value); }

        [Offset(352UL)]
        public IntPtr CurrentWcb { get => ReadHere<IntPtr>(nameof(CurrentWcb)); set => WriteHere(nameof(CurrentWcb), value); }

        [Offset(360UL)]
        public IntPtr CurrentTransferContext { get => ReadHere<IntPtr>(nameof(CurrentTransferContext)); set => WriteHere(nameof(CurrentTransferContext), value); }

        [Offset(368UL)]
        public IntPtr DmaController { get => ReadHere<IntPtr>(nameof(DmaController)); set => WriteHere(nameof(DmaController), value); }

        [Offset(376UL)]
        public uint Controller { get => ReadHere<uint>(nameof(Controller)); set => WriteHere(nameof(Controller), value); }

        [Offset(380UL)]
        public uint ChannelNumber { get => ReadHere<uint>(nameof(ChannelNumber)); set => WriteHere(nameof(ChannelNumber), value); }

        [Offset(384UL)]
        public uint RequestLine { get => ReadHere<uint>(nameof(RequestLine)); set => WriteHere(nameof(RequestLine), value); }

        [Offset(388UL)]
        public uint RequestedChannelCount { get => ReadHere<uint>(nameof(RequestedChannelCount)); set => WriteHere(nameof(RequestedChannelCount), value); }

        [Offset(392UL)]
        public uint AllocatedChannelCount { get => ReadHere<uint>(nameof(AllocatedChannelCount)); set => WriteHere(nameof(AllocatedChannelCount), value); }

        [Offset(396UL)]
        [Length(8)]
        public DynamicArray AllocatedChannels { get => ReadStructure<DynamicArray>(nameof(AllocatedChannels)); set => WriteStructure(nameof(AllocatedChannels), value); }

        [Offset(432UL)]
        public IntPtr ChannelAdapter { get => ReadHere<IntPtr>(nameof(ChannelAdapter)); set => WriteHere(nameof(ChannelAdapter), value); }

        [Offset(440UL)]
        public byte NeedsMapRegisters { get => ReadHere<byte>(nameof(NeedsMapRegisters)); set => WriteHere(nameof(NeedsMapRegisters), value); }

        [Offset(441UL)]
        public byte MasterDevice { get => ReadHere<byte>(nameof(MasterDevice)); set => WriteHere(nameof(MasterDevice), value); }

        [Offset(442UL)]
        public byte ScatterGather { get => ReadHere<byte>(nameof(ScatterGather)); set => WriteHere(nameof(ScatterGather), value); }

        [Offset(443UL)]
        public byte AutoInitialize { get => ReadHere<byte>(nameof(AutoInitialize)); set => WriteHere(nameof(AutoInitialize), value); }

        [Offset(444UL)]
        public byte IgnoreCount { get => ReadHere<byte>(nameof(IgnoreCount)); set => WriteHere(nameof(IgnoreCount), value); }

        [Offset(445UL)]
        public byte CacheCoherent { get => ReadHere<byte>(nameof(CacheCoherent)); set => WriteHere(nameof(CacheCoherent), value); }

        [Offset(448UL)]
        public byte Dma32BitAddresses { get => ReadHere<byte>(nameof(Dma32BitAddresses)); set => WriteHere(nameof(Dma32BitAddresses), value); }

        [Offset(449UL)]
        public byte Dma64BitAddresses { get => ReadHere<byte>(nameof(Dma64BitAddresses)); set => WriteHere(nameof(Dma64BitAddresses), value); }

        [Offset(448UL)]
        public uint DmaAddressWidth { get => ReadHere<uint>(nameof(DmaAddressWidth)); set => WriteHere(nameof(DmaAddressWidth), value); }

        [Offset(452UL)]
        public uint DmaPortWidth { get => ReadHere<uint>(nameof(DmaPortWidth)); set => WriteHere(nameof(DmaPortWidth), value); }

        [Offset(456UL)]
        public LargeInteger DeviceAddress { get => ReadStructure<LargeInteger>(nameof(DeviceAddress)); set => WriteStructure(nameof(DeviceAddress), value); }

        [Offset(464UL)]
        public ListEntry AdapterList { get => ReadStructure<ListEntry>(nameof(AdapterList)); set => WriteStructure(nameof(AdapterList), value); }

        [Offset(480UL)]
        public WorkQueueItem WorkItem { get => ReadStructure<WorkQueueItem>(nameof(WorkItem)); set => WriteStructure(nameof(WorkItem), value); }

        [Offset(512UL)]
        public IntPtr DomainPointer { get => ReadHere<IntPtr>(nameof(DomainPointer)); set => WriteHere(nameof(DomainPointer), value); }

        [Offset(520UL)]
        public uint TranslationType { get => ReadHere<uint>(nameof(TranslationType)); set => WriteHere(nameof(TranslationType), value); }

        [Offset(524UL)]
        public byte AdapterInUse { get => ReadHere<byte>(nameof(AdapterInUse)); set => WriteHere(nameof(AdapterInUse), value); }

        [Offset(528UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(536UL)]
        public IntPtr DeviceId { get => ReadHere<IntPtr>(nameof(DeviceId)); set => WriteHere(nameof(DeviceId), value); }

        [Offset(544UL)]
        public IntPtr IommuDevice { get => ReadHere<IntPtr>(nameof(IommuDevice)); set => WriteHere(nameof(IommuDevice), value); }

        [Offset(552UL)]
        public IntPtr ScatterGatherMdl { get => ReadHere<IntPtr>(nameof(ScatterGatherMdl)); set => WriteHere(nameof(ScatterGatherMdl), value); }

        [Offset(560UL)]
        public IntPtr LowMemoryLogicalAddressToken { get => ReadHere<IntPtr>(nameof(LowMemoryLogicalAddressToken)); set => WriteHere(nameof(LowMemoryLogicalAddressToken), value); }

        [Offset(568UL)]
        public ulong LowMemoryLogicalAddressQueueLock { get => ReadHere<ulong>(nameof(LowMemoryLogicalAddressQueueLock)); set => WriteHere(nameof(LowMemoryLogicalAddressQueueLock), value); }

        [Offset(576UL)]
        public ListEntry LowMemoryLogicalAddressQueue { get => ReadStructure<ListEntry>(nameof(LowMemoryLogicalAddressQueue)); set => WriteStructure(nameof(LowMemoryLogicalAddressQueue), value); }

        [Offset(592UL)]
        public byte LowMemoryLogicalAddressQueueInUse { get => ReadHere<byte>(nameof(LowMemoryLogicalAddressQueueInUse)); set => WriteHere(nameof(LowMemoryLogicalAddressQueueInUse), value); }

        [Offset(600UL)]
        public HalpEmergencyLaQueueEntry LowMemoryLogicalAddressQueueEntry { get => ReadStructure<HalpEmergencyLaQueueEntry>(nameof(LowMemoryLogicalAddressQueueEntry)); set => WriteStructure(nameof(LowMemoryLogicalAddressQueueEntry), value); }

        [Offset(624UL)]
        public uint AllocationState { get => ReadHere<uint>(nameof(AllocationState)); set => WriteHere(nameof(AllocationState), value); }

        [Offset(628UL)]
        public uint ScatterGatherBufferLength { get => ReadHere<uint>(nameof(ScatterGatherBufferLength)); set => WriteHere(nameof(ScatterGatherBufferLength), value); }

        [Offset(632UL)]
        public ScatterGatherList ScatterGatherBuffer { get => ReadStructure<ScatterGatherList>(nameof(ScatterGatherBuffer)); set => WriteStructure(nameof(ScatterGatherBuffer), value); }

        public AdapterObject(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AdapterObject>();
        }
    }
}