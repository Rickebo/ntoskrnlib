#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 624)]
    public partial struct _HAL_INTEL_ENLIGHTENMENT_INFORMATION
    {
        [FieldOffset(0)]
        public uint Enlightenments;
        [FieldOffset(4)]
        public uint HypervisorConnected;
        [FieldOffset(8)]
        public IntPtr EndOfInterrupt;
        [FieldOffset(16)]
        public IntPtr ApicWriteIcr;
        [FieldOffset(24)]
        public uint Reserved0;
        [FieldOffset(28)]
        public uint SpinCountMask;
        [FieldOffset(32)]
        public IntPtr LongSpinWait;
        [FieldOffset(40)]
        public IntPtr GetReferenceTime;
        [FieldOffset(48)]
        public IntPtr SetSystemSleepProperty;
        [FieldOffset(56)]
        public IntPtr EnterSleepState;
        [FieldOffset(64)]
        public IntPtr NotifyDebugDeviceAvailable;
        [FieldOffset(72)]
        public IntPtr MapDeviceInterrupt;
        [FieldOffset(80)]
        public IntPtr UnmapDeviceInterrupt;
        [FieldOffset(88)]
        public IntPtr RetargetDeviceInterrupt;
        [FieldOffset(96)]
        public IntPtr SetHpetConfig;
        [FieldOffset(104)]
        public IntPtr NotifyHpetEnabled;
        [FieldOffset(112)]
        public IntPtr QueryAssociatedProcessors;
        [FieldOffset(120)]
        public IntPtr ReadMultipleMsr;
        [FieldOffset(128)]
        public IntPtr WriteMultipleMsr;
        [FieldOffset(136)]
        public IntPtr ReadCpuid;
        [FieldOffset(144)]
        public IntPtr LpWritebackInvalidate;
        [FieldOffset(152)]
        public IntPtr GetMachineCheckContext;
        [FieldOffset(160)]
        public IntPtr SuspendPartition;
        [FieldOffset(168)]
        public IntPtr ResumePartition;
        [FieldOffset(176)]
        public IntPtr SetSystemMachineCheckProperty;
        [FieldOffset(184)]
        public IntPtr WheaErrorNotification;
        [FieldOffset(192)]
        public IntPtr GetProcessorIndexFromVpIndex;
        [FieldOffset(200)]
        public IntPtr SyntheticClusterIpi;
        [FieldOffset(208)]
        public IntPtr VpStartEnabled;
        [FieldOffset(216)]
        public IntPtr StartVirtualProcessor;
        [FieldOffset(224)]
        public IntPtr GetVpIndexFromApicId;
        [FieldOffset(232)]
        public IntPtr IumAccessPciDevice;
        [FieldOffset(240)]
        public IntPtr IumEfiRuntimeService;
        [FieldOffset(248)]
        public IntPtr GetSystemPasidCapabilities;
        [FieldOffset(256)]
        public IntPtr GetDeviceCapabilities;
        [FieldOffset(264)]
        public IntPtr CreatePasidSpace;
        [FieldOffset(272)]
        public IntPtr SetPasidAddressSpace;
        [FieldOffset(280)]
        public IntPtr FlushPasid;
        [FieldOffset(288)]
        public IntPtr AttachPasidSpace;
        [FieldOffset(296)]
        public IntPtr DetachPasidSpace;
        [FieldOffset(304)]
        public IntPtr EnablePasid;
        [FieldOffset(312)]
        public IntPtr DisablePasid;
        [FieldOffset(320)]
        public IntPtr AcknowledgePageRequest;
        [FieldOffset(328)]
        public IntPtr CreatePrQueue;
        [FieldOffset(336)]
        public IntPtr DeletePrQueue;
        [FieldOffset(344)]
        public IntPtr ClearPrqStalled;
        [FieldOffset(352)]
        public IntPtr SetDeviceDmaEnabled;
        [FieldOffset(360)]
        public IntPtr SetDeviceCapabilities;
        [FieldOffset(368)]
        public IntPtr AttachPrQueue;
        [FieldOffset(376)]
        public IntPtr DetachPrQueue;
        [FieldOffset(384)]
        public IntPtr HvDebuggerPowerHandler;
        [FieldOffset(392)]
        public IntPtr SetQpcBias;
        [FieldOffset(400)]
        public IntPtr GetQpcBias;
        [FieldOffset(408)]
        public IntPtr RegisterDeviceId;
        [FieldOffset(416)]
        public IntPtr UnregisterDeviceId;
        [FieldOffset(424)]
        public IntPtr AllocateDeviceDomain;
        [FieldOffset(432)]
        public IntPtr AttachDeviceDomain;
        [FieldOffset(440)]
        public IntPtr DetachDeviceDomain;
        [FieldOffset(448)]
        public IntPtr DeleteDeviceDomain;
        [FieldOffset(456)]
        public IntPtr MapDeviceLogicalRange;
        [FieldOffset(464)]
        public IntPtr UnmapDeviceLogicalRange;
        [FieldOffset(472)]
        public IntPtr MapDeviceSparsePages;
        [FieldOffset(480)]
        public IntPtr UnmapDeviceSparsePages;
        [FieldOffset(488)]
        public IntPtr GetDmaGuardEnabled;
        [FieldOffset(496)]
        public IntPtr UpdateMicrocode;
        [FieldOffset(504)]
        public IntPtr GetMicrocodeLatency;
        [FieldOffset(512)]
        public IntPtr GetSintMessage;
        [FieldOffset(520)]
        public IntPtr GetSintMessagePage;
        [FieldOffset(528)]
        public IntPtr RestoreTime;
        [FieldOffset(536)]
        public IntPtr GetLogicalProcessorHwId;
        [FieldOffset(544)]
        public IntPtr WakeVirtualProcessors;
        [FieldOffset(552)]
        public IntPtr SetRootFaultReportingReady;
        [FieldOffset(560)]
        public IntPtr ConfigureDeviceDomain;
        [FieldOffset(568)]
        public IntPtr UnblockDefaultDma;
        [FieldOffset(576)]
        public IntPtr FlushDeviceDomain;
        [FieldOffset(584)]
        public IntPtr FlushDeviceDomainVaList;
        [FieldOffset(592)]
        public IntPtr GetHybridPassthroughReservedRegions;
        [FieldOffset(600)]
        public IntPtr ReserveDeviceDomainAttachment;
        [FieldOffset(608)]
        public IntPtr UnreserveDeviceDomainAttachment;
        [FieldOffset(616)]
        public IntPtr ChangeIsolatedMemoryVisibility;
    }
}