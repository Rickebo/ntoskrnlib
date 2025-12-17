using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HV_X64_HYPERVISOR_FEATURES")]
    public sealed class HvX64HypervisorFeatures : DynamicStructure
    {
        [Offset(0UL)]
        public HvPartitionPrivilegeMask PartitionPrivileges { get => ReadStructure<HvPartitionPrivilegeMask>(nameof(PartitionPrivileges)); set => WriteStructure(nameof(PartitionPrivileges), value); }

        [Offset(8UL)]
        public uint MaxSupportedCState { get => ReadHere<uint>(nameof(MaxSupportedCState)); set => WriteHere(nameof(MaxSupportedCState), value); }

        [Offset(8UL)]
        public uint HpetNeededForC3PowerState_Deprecated { get => ReadHere<uint>(nameof(HpetNeededForC3PowerState_Deprecated)); set => WriteHere(nameof(HpetNeededForC3PowerState_Deprecated), value); }

        [Offset(8UL)]
        public uint InvariantMperfAvailable { get => ReadHere<uint>(nameof(InvariantMperfAvailable)); set => WriteHere(nameof(InvariantMperfAvailable), value); }

        [Offset(8UL)]
        public uint SupervisorShadowStackAvailable { get => ReadHere<uint>(nameof(SupervisorShadowStackAvailable)); set => WriteHere(nameof(SupervisorShadowStackAvailable), value); }

        [Offset(8UL)]
        public uint ArchPmuAvailable { get => ReadHere<uint>(nameof(ArchPmuAvailable)); set => WriteHere(nameof(ArchPmuAvailable), value); }

        [Offset(8UL)]
        public uint ExceptionTrapInterceptAvailable { get => ReadHere<uint>(nameof(ExceptionTrapInterceptAvailable)); set => WriteHere(nameof(ExceptionTrapInterceptAvailable), value); }

        [Offset(8UL)]
        public uint VpDispatchInterruptInjectionAvailable { get => ReadHere<uint>(nameof(VpDispatchInterruptInjectionAvailable)); set => WriteHere(nameof(VpDispatchInterruptInjectionAvailable), value); }

        [Offset(8UL)]
        public uint GhcbRootMappingAvailable { get => ReadHere<uint>(nameof(GhcbRootMappingAvailable)); set => WriteHere(nameof(GhcbRootMappingAvailable), value); }

        [Offset(8UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(12UL)]
        public uint MwaitAvailable_Deprecated { get => ReadHere<uint>(nameof(MwaitAvailable_Deprecated)); set => WriteHere(nameof(MwaitAvailable_Deprecated), value); }

        [Offset(12UL)]
        public uint GuestDebuggingAvailable { get => ReadHere<uint>(nameof(GuestDebuggingAvailable)); set => WriteHere(nameof(GuestDebuggingAvailable), value); }

        [Offset(12UL)]
        public uint PerformanceMonitorsAvailable { get => ReadHere<uint>(nameof(PerformanceMonitorsAvailable)); set => WriteHere(nameof(PerformanceMonitorsAvailable), value); }

        [Offset(12UL)]
        public uint CpuDynamicPartitioningAvailable { get => ReadHere<uint>(nameof(CpuDynamicPartitioningAvailable)); set => WriteHere(nameof(CpuDynamicPartitioningAvailable), value); }

        [Offset(12UL)]
        public uint XmmRegistersForFastHypercallAvailable { get => ReadHere<uint>(nameof(XmmRegistersForFastHypercallAvailable)); set => WriteHere(nameof(XmmRegistersForFastHypercallAvailable), value); }

        [Offset(12UL)]
        public uint GuestIdleAvailable { get => ReadHere<uint>(nameof(GuestIdleAvailable)); set => WriteHere(nameof(GuestIdleAvailable), value); }

        [Offset(12UL)]
        public uint HypervisorSleepStateSupportAvailable { get => ReadHere<uint>(nameof(HypervisorSleepStateSupportAvailable)); set => WriteHere(nameof(HypervisorSleepStateSupportAvailable), value); }

        [Offset(12UL)]
        public uint NumaDistanceQueryAvailable { get => ReadHere<uint>(nameof(NumaDistanceQueryAvailable)); set => WriteHere(nameof(NumaDistanceQueryAvailable), value); }

        [Offset(12UL)]
        public uint FrequencyRegsAvailable { get => ReadHere<uint>(nameof(FrequencyRegsAvailable)); set => WriteHere(nameof(FrequencyRegsAvailable), value); }

        [Offset(12UL)]
        public uint SyntheticMachineCheckAvailable { get => ReadHere<uint>(nameof(SyntheticMachineCheckAvailable)); set => WriteHere(nameof(SyntheticMachineCheckAvailable), value); }

        [Offset(12UL)]
        public uint GuestCrashRegsAvailable { get => ReadHere<uint>(nameof(GuestCrashRegsAvailable)); set => WriteHere(nameof(GuestCrashRegsAvailable), value); }

        [Offset(12UL)]
        public uint DebugRegsAvailable { get => ReadHere<uint>(nameof(DebugRegsAvailable)); set => WriteHere(nameof(DebugRegsAvailable), value); }

        [Offset(12UL)]
        public uint Npiep1Available { get => ReadHere<uint>(nameof(Npiep1Available)); set => WriteHere(nameof(Npiep1Available), value); }

        [Offset(12UL)]
        public uint DisableHypervisorAvailable { get => ReadHere<uint>(nameof(DisableHypervisorAvailable)); set => WriteHere(nameof(DisableHypervisorAvailable), value); }

        [Offset(12UL)]
        public uint ExtendedGvaRangesForFlushVirtualAddressListAvailable { get => ReadHere<uint>(nameof(ExtendedGvaRangesForFlushVirtualAddressListAvailable)); set => WriteHere(nameof(ExtendedGvaRangesForFlushVirtualAddressListAvailable), value); }

        [Offset(12UL)]
        public uint FastHypercallOutputAvailable { get => ReadHere<uint>(nameof(FastHypercallOutputAvailable)); set => WriteHere(nameof(FastHypercallOutputAvailable), value); }

        [Offset(12UL)]
        public uint PasidFeaturesAvailable { get => ReadHere<uint>(nameof(PasidFeaturesAvailable)); set => WriteHere(nameof(PasidFeaturesAvailable), value); }

        [Offset(12UL)]
        public uint SintPollingModeAvailable { get => ReadHere<uint>(nameof(SintPollingModeAvailable)); set => WriteHere(nameof(SintPollingModeAvailable), value); }

        [Offset(12UL)]
        public uint HypercallMsrLockAvailable { get => ReadHere<uint>(nameof(HypercallMsrLockAvailable)); set => WriteHere(nameof(HypercallMsrLockAvailable), value); }

        [Offset(12UL)]
        public uint DirectSyntheticTimers { get => ReadHere<uint>(nameof(DirectSyntheticTimers)); set => WriteHere(nameof(DirectSyntheticTimers), value); }

        [Offset(12UL)]
        public uint RegisterPatAvailable { get => ReadHere<uint>(nameof(RegisterPatAvailable)); set => WriteHere(nameof(RegisterPatAvailable), value); }

        [Offset(12UL)]
        public uint RegisterBndcfgsAvailable { get => ReadHere<uint>(nameof(RegisterBndcfgsAvailable)); set => WriteHere(nameof(RegisterBndcfgsAvailable), value); }

        [Offset(12UL)]
        public uint WatchdogTimerAvailable { get => ReadHere<uint>(nameof(WatchdogTimerAvailable)); set => WriteHere(nameof(WatchdogTimerAvailable), value); }

        [Offset(12UL)]
        public uint SyntheticTimeUnhaltedTimerAvailable { get => ReadHere<uint>(nameof(SyntheticTimeUnhaltedTimerAvailable)); set => WriteHere(nameof(SyntheticTimeUnhaltedTimerAvailable), value); }

        [Offset(12UL)]
        public uint DeviceDomainsAvailable { get => ReadHere<uint>(nameof(DeviceDomainsAvailable)); set => WriteHere(nameof(DeviceDomainsAvailable), value); }

        [Offset(12UL)]
        public uint S1DeviceDomainsAvailable { get => ReadHere<uint>(nameof(S1DeviceDomainsAvailable)); set => WriteHere(nameof(S1DeviceDomainsAvailable), value); }

        [Offset(12UL)]
        public uint LbrAvailable { get => ReadHere<uint>(nameof(LbrAvailable)); set => WriteHere(nameof(LbrAvailable), value); }

        [Offset(12UL)]
        public uint IptAvailable { get => ReadHere<uint>(nameof(IptAvailable)); set => WriteHere(nameof(IptAvailable), value); }

        [Offset(12UL)]
        public uint CrossVtlFlushAvailable { get => ReadHere<uint>(nameof(CrossVtlFlushAvailable)); set => WriteHere(nameof(CrossVtlFlushAvailable), value); }

        [Offset(12UL)]
        public uint IdleSpecCtrlAvailable { get => ReadHere<uint>(nameof(IdleSpecCtrlAvailable)); set => WriteHere(nameof(IdleSpecCtrlAvailable), value); }

        [Offset(12UL)]
        public uint TranslateGvaFlagsAvailable { get => ReadHere<uint>(nameof(TranslateGvaFlagsAvailable)); set => WriteHere(nameof(TranslateGvaFlagsAvailable), value); }

        [Offset(12UL)]
        public uint ApicEoiInterceptAvailable { get => ReadHere<uint>(nameof(ApicEoiInterceptAvailable)); set => WriteHere(nameof(ApicEoiInterceptAvailable), value); }

        public HvX64HypervisorFeatures(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HvX64HypervisorFeatures>();
        }
    }
}