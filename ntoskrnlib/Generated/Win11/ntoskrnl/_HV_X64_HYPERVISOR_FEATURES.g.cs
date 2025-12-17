#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HV_X64_HYPERVISOR_FEATURES
    {
        [FieldOffset(0)]
        public _HV_PARTITION_PRIVILEGE_MASK PartitionPrivileges;
        [FieldOffset(8)]
        public uint MaxSupportedCState;
        [FieldOffset(8)]
        public uint HpetNeededForC3PowerState_Deprecated;
        [FieldOffset(8)]
        public uint InvariantMperfAvailable;
        [FieldOffset(8)]
        public uint SupervisorShadowStackAvailable;
        [FieldOffset(8)]
        public uint ArchPmuAvailable;
        [FieldOffset(8)]
        public uint ExceptionTrapInterceptAvailable;
        [FieldOffset(8)]
        public uint VpDispatchInterruptInjectionAvailable;
        [FieldOffset(8)]
        public uint GhcbRootMappingAvailable;
        [FieldOffset(8)]
        public uint Reserved;
        [FieldOffset(12)]
        public uint MwaitAvailable_Deprecated;
        [FieldOffset(12)]
        public uint GuestDebuggingAvailable;
        [FieldOffset(12)]
        public uint PerformanceMonitorsAvailable;
        [FieldOffset(12)]
        public uint CpuDynamicPartitioningAvailable;
        [FieldOffset(12)]
        public uint XmmRegistersForFastHypercallAvailable;
        [FieldOffset(12)]
        public uint GuestIdleAvailable;
        [FieldOffset(12)]
        public uint HypervisorSleepStateSupportAvailable;
        [FieldOffset(12)]
        public uint NumaDistanceQueryAvailable;
        [FieldOffset(12)]
        public uint FrequencyRegsAvailable;
        [FieldOffset(12)]
        public uint SyntheticMachineCheckAvailable;
        [FieldOffset(12)]
        public uint GuestCrashRegsAvailable;
        [FieldOffset(12)]
        public uint DebugRegsAvailable;
        [FieldOffset(12)]
        public uint Npiep1Available;
        [FieldOffset(12)]
        public uint DisableHypervisorAvailable;
        [FieldOffset(12)]
        public uint ExtendedGvaRangesForFlushVirtualAddressListAvailable;
        [FieldOffset(12)]
        public uint FastHypercallOutputAvailable;
        [FieldOffset(12)]
        public uint PasidFeaturesAvailable;
        [FieldOffset(12)]
        public uint SintPollingModeAvailable;
        [FieldOffset(12)]
        public uint HypercallMsrLockAvailable;
        [FieldOffset(12)]
        public uint DirectSyntheticTimers;
        [FieldOffset(12)]
        public uint RegisterPatAvailable;
        [FieldOffset(12)]
        public uint RegisterBndcfgsAvailable;
        [FieldOffset(12)]
        public uint WatchdogTimerAvailable;
        [FieldOffset(12)]
        public uint SyntheticTimeUnhaltedTimerAvailable;
        [FieldOffset(12)]
        public uint DeviceDomainsAvailable;
        [FieldOffset(12)]
        public uint S1DeviceDomainsAvailable;
        [FieldOffset(12)]
        public uint LbrAvailable;
        [FieldOffset(12)]
        public uint IptAvailable;
        [FieldOffset(12)]
        public uint CrossVtlFlushAvailable;
        [FieldOffset(12)]
        public uint IdleSpecCtrlAvailable;
        [FieldOffset(12)]
        public uint TranslateGvaFlagsAvailable;
        [FieldOffset(12)]
        public uint ApicEoiInterceptAvailable;
    }
}