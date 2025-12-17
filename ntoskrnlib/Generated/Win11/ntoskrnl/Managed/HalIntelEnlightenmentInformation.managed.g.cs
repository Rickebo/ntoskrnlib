using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HAL_INTEL_ENLIGHTENMENT_INFORMATION")]
    public sealed class HalIntelEnlightenmentInformation : DynamicStructure
    {
        [Offset(0UL)]
        public uint Enlightenments { get => ReadHere<uint>(nameof(Enlightenments)); set => WriteHere(nameof(Enlightenments), value); }

        [Offset(4UL)]
        public uint HypervisorConnected { get => ReadHere<uint>(nameof(HypervisorConnected)); set => WriteHere(nameof(HypervisorConnected), value); }

        [Offset(8UL)]
        public IntPtr EndOfInterrupt { get => ReadHere<IntPtr>(nameof(EndOfInterrupt)); set => WriteHere(nameof(EndOfInterrupt), value); }

        [Offset(16UL)]
        public IntPtr ApicWriteIcr { get => ReadHere<IntPtr>(nameof(ApicWriteIcr)); set => WriteHere(nameof(ApicWriteIcr), value); }

        [Offset(24UL)]
        public uint Reserved0 { get => ReadHere<uint>(nameof(Reserved0)); set => WriteHere(nameof(Reserved0), value); }

        [Offset(28UL)]
        public uint SpinCountMask { get => ReadHere<uint>(nameof(SpinCountMask)); set => WriteHere(nameof(SpinCountMask), value); }

        [Offset(32UL)]
        public IntPtr LongSpinWait { get => ReadHere<IntPtr>(nameof(LongSpinWait)); set => WriteHere(nameof(LongSpinWait), value); }

        [Offset(40UL)]
        public IntPtr GetReferenceTime { get => ReadHere<IntPtr>(nameof(GetReferenceTime)); set => WriteHere(nameof(GetReferenceTime), value); }

        [Offset(48UL)]
        public IntPtr SetSystemSleepProperty { get => ReadHere<IntPtr>(nameof(SetSystemSleepProperty)); set => WriteHere(nameof(SetSystemSleepProperty), value); }

        [Offset(56UL)]
        public IntPtr EnterSleepState { get => ReadHere<IntPtr>(nameof(EnterSleepState)); set => WriteHere(nameof(EnterSleepState), value); }

        [Offset(64UL)]
        public IntPtr NotifyDebugDeviceAvailable { get => ReadHere<IntPtr>(nameof(NotifyDebugDeviceAvailable)); set => WriteHere(nameof(NotifyDebugDeviceAvailable), value); }

        [Offset(72UL)]
        public IntPtr MapDeviceInterrupt { get => ReadHere<IntPtr>(nameof(MapDeviceInterrupt)); set => WriteHere(nameof(MapDeviceInterrupt), value); }

        [Offset(80UL)]
        public IntPtr UnmapDeviceInterrupt { get => ReadHere<IntPtr>(nameof(UnmapDeviceInterrupt)); set => WriteHere(nameof(UnmapDeviceInterrupt), value); }

        [Offset(88UL)]
        public IntPtr RetargetDeviceInterrupt { get => ReadHere<IntPtr>(nameof(RetargetDeviceInterrupt)); set => WriteHere(nameof(RetargetDeviceInterrupt), value); }

        [Offset(96UL)]
        public IntPtr SetHpetConfig { get => ReadHere<IntPtr>(nameof(SetHpetConfig)); set => WriteHere(nameof(SetHpetConfig), value); }

        [Offset(104UL)]
        public IntPtr NotifyHpetEnabled { get => ReadHere<IntPtr>(nameof(NotifyHpetEnabled)); set => WriteHere(nameof(NotifyHpetEnabled), value); }

        [Offset(112UL)]
        public IntPtr QueryAssociatedProcessors { get => ReadHere<IntPtr>(nameof(QueryAssociatedProcessors)); set => WriteHere(nameof(QueryAssociatedProcessors), value); }

        [Offset(120UL)]
        public IntPtr ReadMultipleMsr { get => ReadHere<IntPtr>(nameof(ReadMultipleMsr)); set => WriteHere(nameof(ReadMultipleMsr), value); }

        [Offset(128UL)]
        public IntPtr WriteMultipleMsr { get => ReadHere<IntPtr>(nameof(WriteMultipleMsr)); set => WriteHere(nameof(WriteMultipleMsr), value); }

        [Offset(136UL)]
        public IntPtr ReadCpuid { get => ReadHere<IntPtr>(nameof(ReadCpuid)); set => WriteHere(nameof(ReadCpuid), value); }

        [Offset(144UL)]
        public IntPtr LpWritebackInvalidate { get => ReadHere<IntPtr>(nameof(LpWritebackInvalidate)); set => WriteHere(nameof(LpWritebackInvalidate), value); }

        [Offset(152UL)]
        public IntPtr GetMachineCheckContext { get => ReadHere<IntPtr>(nameof(GetMachineCheckContext)); set => WriteHere(nameof(GetMachineCheckContext), value); }

        [Offset(160UL)]
        public IntPtr SuspendPartition { get => ReadHere<IntPtr>(nameof(SuspendPartition)); set => WriteHere(nameof(SuspendPartition), value); }

        [Offset(168UL)]
        public IntPtr ResumePartition { get => ReadHere<IntPtr>(nameof(ResumePartition)); set => WriteHere(nameof(ResumePartition), value); }

        [Offset(176UL)]
        public IntPtr SetSystemMachineCheckProperty { get => ReadHere<IntPtr>(nameof(SetSystemMachineCheckProperty)); set => WriteHere(nameof(SetSystemMachineCheckProperty), value); }

        [Offset(184UL)]
        public IntPtr WheaErrorNotification { get => ReadHere<IntPtr>(nameof(WheaErrorNotification)); set => WriteHere(nameof(WheaErrorNotification), value); }

        [Offset(192UL)]
        public IntPtr GetProcessorIndexFromVpIndex { get => ReadHere<IntPtr>(nameof(GetProcessorIndexFromVpIndex)); set => WriteHere(nameof(GetProcessorIndexFromVpIndex), value); }

        [Offset(200UL)]
        public IntPtr SyntheticClusterIpi { get => ReadHere<IntPtr>(nameof(SyntheticClusterIpi)); set => WriteHere(nameof(SyntheticClusterIpi), value); }

        [Offset(208UL)]
        public IntPtr VpStartEnabled { get => ReadHere<IntPtr>(nameof(VpStartEnabled)); set => WriteHere(nameof(VpStartEnabled), value); }

        [Offset(216UL)]
        public IntPtr StartVirtualProcessor { get => ReadHere<IntPtr>(nameof(StartVirtualProcessor)); set => WriteHere(nameof(StartVirtualProcessor), value); }

        [Offset(224UL)]
        public IntPtr GetVpIndexFromApicId { get => ReadHere<IntPtr>(nameof(GetVpIndexFromApicId)); set => WriteHere(nameof(GetVpIndexFromApicId), value); }

        [Offset(232UL)]
        public IntPtr IumAccessPciDevice { get => ReadHere<IntPtr>(nameof(IumAccessPciDevice)); set => WriteHere(nameof(IumAccessPciDevice), value); }

        [Offset(240UL)]
        public IntPtr IumEfiRuntimeService { get => ReadHere<IntPtr>(nameof(IumEfiRuntimeService)); set => WriteHere(nameof(IumEfiRuntimeService), value); }

        [Offset(248UL)]
        public IntPtr GetSystemPasidCapabilities { get => ReadHere<IntPtr>(nameof(GetSystemPasidCapabilities)); set => WriteHere(nameof(GetSystemPasidCapabilities), value); }

        [Offset(256UL)]
        public IntPtr GetDeviceCapabilities { get => ReadHere<IntPtr>(nameof(GetDeviceCapabilities)); set => WriteHere(nameof(GetDeviceCapabilities), value); }

        [Offset(264UL)]
        public IntPtr CreatePasidSpace { get => ReadHere<IntPtr>(nameof(CreatePasidSpace)); set => WriteHere(nameof(CreatePasidSpace), value); }

        [Offset(272UL)]
        public IntPtr SetPasidAddressSpace { get => ReadHere<IntPtr>(nameof(SetPasidAddressSpace)); set => WriteHere(nameof(SetPasidAddressSpace), value); }

        [Offset(280UL)]
        public IntPtr FlushPasid { get => ReadHere<IntPtr>(nameof(FlushPasid)); set => WriteHere(nameof(FlushPasid), value); }

        [Offset(288UL)]
        public IntPtr AttachPasidSpace { get => ReadHere<IntPtr>(nameof(AttachPasidSpace)); set => WriteHere(nameof(AttachPasidSpace), value); }

        [Offset(296UL)]
        public IntPtr DetachPasidSpace { get => ReadHere<IntPtr>(nameof(DetachPasidSpace)); set => WriteHere(nameof(DetachPasidSpace), value); }

        [Offset(304UL)]
        public IntPtr EnablePasid { get => ReadHere<IntPtr>(nameof(EnablePasid)); set => WriteHere(nameof(EnablePasid), value); }

        [Offset(312UL)]
        public IntPtr DisablePasid { get => ReadHere<IntPtr>(nameof(DisablePasid)); set => WriteHere(nameof(DisablePasid), value); }

        [Offset(320UL)]
        public IntPtr AcknowledgePageRequest { get => ReadHere<IntPtr>(nameof(AcknowledgePageRequest)); set => WriteHere(nameof(AcknowledgePageRequest), value); }

        [Offset(328UL)]
        public IntPtr CreatePrQueue { get => ReadHere<IntPtr>(nameof(CreatePrQueue)); set => WriteHere(nameof(CreatePrQueue), value); }

        [Offset(336UL)]
        public IntPtr DeletePrQueue { get => ReadHere<IntPtr>(nameof(DeletePrQueue)); set => WriteHere(nameof(DeletePrQueue), value); }

        [Offset(344UL)]
        public IntPtr ClearPrqStalled { get => ReadHere<IntPtr>(nameof(ClearPrqStalled)); set => WriteHere(nameof(ClearPrqStalled), value); }

        [Offset(352UL)]
        public IntPtr SetDeviceDmaEnabled { get => ReadHere<IntPtr>(nameof(SetDeviceDmaEnabled)); set => WriteHere(nameof(SetDeviceDmaEnabled), value); }

        [Offset(360UL)]
        public IntPtr SetDeviceCapabilities { get => ReadHere<IntPtr>(nameof(SetDeviceCapabilities)); set => WriteHere(nameof(SetDeviceCapabilities), value); }

        [Offset(368UL)]
        public IntPtr AttachPrQueue { get => ReadHere<IntPtr>(nameof(AttachPrQueue)); set => WriteHere(nameof(AttachPrQueue), value); }

        [Offset(376UL)]
        public IntPtr DetachPrQueue { get => ReadHere<IntPtr>(nameof(DetachPrQueue)); set => WriteHere(nameof(DetachPrQueue), value); }

        [Offset(384UL)]
        public IntPtr HvDebuggerPowerHandler { get => ReadHere<IntPtr>(nameof(HvDebuggerPowerHandler)); set => WriteHere(nameof(HvDebuggerPowerHandler), value); }

        [Offset(392UL)]
        public IntPtr SetQpcBias { get => ReadHere<IntPtr>(nameof(SetQpcBias)); set => WriteHere(nameof(SetQpcBias), value); }

        [Offset(400UL)]
        public IntPtr GetQpcBias { get => ReadHere<IntPtr>(nameof(GetQpcBias)); set => WriteHere(nameof(GetQpcBias), value); }

        [Offset(408UL)]
        public IntPtr RegisterDeviceId { get => ReadHere<IntPtr>(nameof(RegisterDeviceId)); set => WriteHere(nameof(RegisterDeviceId), value); }

        [Offset(416UL)]
        public IntPtr UnregisterDeviceId { get => ReadHere<IntPtr>(nameof(UnregisterDeviceId)); set => WriteHere(nameof(UnregisterDeviceId), value); }

        [Offset(424UL)]
        public IntPtr AllocateDeviceDomain { get => ReadHere<IntPtr>(nameof(AllocateDeviceDomain)); set => WriteHere(nameof(AllocateDeviceDomain), value); }

        [Offset(432UL)]
        public IntPtr AttachDeviceDomain { get => ReadHere<IntPtr>(nameof(AttachDeviceDomain)); set => WriteHere(nameof(AttachDeviceDomain), value); }

        [Offset(440UL)]
        public IntPtr DetachDeviceDomain { get => ReadHere<IntPtr>(nameof(DetachDeviceDomain)); set => WriteHere(nameof(DetachDeviceDomain), value); }

        [Offset(448UL)]
        public IntPtr DeleteDeviceDomain { get => ReadHere<IntPtr>(nameof(DeleteDeviceDomain)); set => WriteHere(nameof(DeleteDeviceDomain), value); }

        [Offset(456UL)]
        public IntPtr MapDeviceLogicalRange { get => ReadHere<IntPtr>(nameof(MapDeviceLogicalRange)); set => WriteHere(nameof(MapDeviceLogicalRange), value); }

        [Offset(464UL)]
        public IntPtr UnmapDeviceLogicalRange { get => ReadHere<IntPtr>(nameof(UnmapDeviceLogicalRange)); set => WriteHere(nameof(UnmapDeviceLogicalRange), value); }

        [Offset(472UL)]
        public IntPtr MapDeviceSparsePages { get => ReadHere<IntPtr>(nameof(MapDeviceSparsePages)); set => WriteHere(nameof(MapDeviceSparsePages), value); }

        [Offset(480UL)]
        public IntPtr UnmapDeviceSparsePages { get => ReadHere<IntPtr>(nameof(UnmapDeviceSparsePages)); set => WriteHere(nameof(UnmapDeviceSparsePages), value); }

        [Offset(488UL)]
        public IntPtr GetDmaGuardEnabled { get => ReadHere<IntPtr>(nameof(GetDmaGuardEnabled)); set => WriteHere(nameof(GetDmaGuardEnabled), value); }

        [Offset(496UL)]
        public IntPtr UpdateMicrocode { get => ReadHere<IntPtr>(nameof(UpdateMicrocode)); set => WriteHere(nameof(UpdateMicrocode), value); }

        [Offset(504UL)]
        public IntPtr GetMicrocodeLatency { get => ReadHere<IntPtr>(nameof(GetMicrocodeLatency)); set => WriteHere(nameof(GetMicrocodeLatency), value); }

        [Offset(512UL)]
        public IntPtr GetSintMessage { get => ReadHere<IntPtr>(nameof(GetSintMessage)); set => WriteHere(nameof(GetSintMessage), value); }

        [Offset(520UL)]
        public IntPtr GetSintMessagePage { get => ReadHere<IntPtr>(nameof(GetSintMessagePage)); set => WriteHere(nameof(GetSintMessagePage), value); }

        [Offset(528UL)]
        public IntPtr RestoreTime { get => ReadHere<IntPtr>(nameof(RestoreTime)); set => WriteHere(nameof(RestoreTime), value); }

        [Offset(536UL)]
        public IntPtr GetLogicalProcessorHwId { get => ReadHere<IntPtr>(nameof(GetLogicalProcessorHwId)); set => WriteHere(nameof(GetLogicalProcessorHwId), value); }

        [Offset(544UL)]
        public IntPtr WakeVirtualProcessors { get => ReadHere<IntPtr>(nameof(WakeVirtualProcessors)); set => WriteHere(nameof(WakeVirtualProcessors), value); }

        [Offset(552UL)]
        public IntPtr SetRootFaultReportingReady { get => ReadHere<IntPtr>(nameof(SetRootFaultReportingReady)); set => WriteHere(nameof(SetRootFaultReportingReady), value); }

        [Offset(560UL)]
        public IntPtr ConfigureDeviceDomain { get => ReadHere<IntPtr>(nameof(ConfigureDeviceDomain)); set => WriteHere(nameof(ConfigureDeviceDomain), value); }

        [Offset(568UL)]
        public IntPtr UnblockDefaultDma { get => ReadHere<IntPtr>(nameof(UnblockDefaultDma)); set => WriteHere(nameof(UnblockDefaultDma), value); }

        [Offset(576UL)]
        public IntPtr FlushDeviceDomain { get => ReadHere<IntPtr>(nameof(FlushDeviceDomain)); set => WriteHere(nameof(FlushDeviceDomain), value); }

        [Offset(584UL)]
        public IntPtr FlushDeviceDomainVaList { get => ReadHere<IntPtr>(nameof(FlushDeviceDomainVaList)); set => WriteHere(nameof(FlushDeviceDomainVaList), value); }

        [Offset(592UL)]
        public IntPtr GetHybridPassthroughReservedRegions { get => ReadHere<IntPtr>(nameof(GetHybridPassthroughReservedRegions)); set => WriteHere(nameof(GetHybridPassthroughReservedRegions), value); }

        [Offset(600UL)]
        public IntPtr ReserveDeviceDomainAttachment { get => ReadHere<IntPtr>(nameof(ReserveDeviceDomainAttachment)); set => WriteHere(nameof(ReserveDeviceDomainAttachment), value); }

        [Offset(608UL)]
        public IntPtr UnreserveDeviceDomainAttachment { get => ReadHere<IntPtr>(nameof(UnreserveDeviceDomainAttachment)); set => WriteHere(nameof(UnreserveDeviceDomainAttachment), value); }

        [Offset(616UL)]
        public IntPtr ChangeIsolatedMemoryVisibility { get => ReadHere<IntPtr>(nameof(ChangeIsolatedMemoryVisibility)); set => WriteHere(nameof(ChangeIsolatedMemoryVisibility), value); }

        public HalIntelEnlightenmentInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalIntelEnlightenmentInformation>();
        }
    }
}