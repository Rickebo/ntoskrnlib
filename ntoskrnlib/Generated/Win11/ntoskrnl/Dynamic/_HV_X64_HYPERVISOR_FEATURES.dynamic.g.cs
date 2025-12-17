using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HV_X64_HYPERVISOR_FEATURES")]
    public sealed class _HV_X64_HYPERVISOR_FEATURES : DynamicStructure
    {
        public _HV_PARTITION_PRIVILEGE_MASK PartitionPrivileges { get; }
        public uint MaxSupportedCState { get; }
        public uint HpetNeededForC3PowerState_Deprecated { get; }
        public uint InvariantMperfAvailable { get; }
        public uint SupervisorShadowStackAvailable { get; }
        public uint ArchPmuAvailable { get; }
        public uint ExceptionTrapInterceptAvailable { get; }
        public uint VpDispatchInterruptInjectionAvailable { get; }
        public uint GhcbRootMappingAvailable { get; }
        public uint Reserved { get; }
        public uint MwaitAvailable_Deprecated { get; }
        public uint GuestDebuggingAvailable { get; }
        public uint PerformanceMonitorsAvailable { get; }
        public uint CpuDynamicPartitioningAvailable { get; }
        public uint XmmRegistersForFastHypercallAvailable { get; }
        public uint GuestIdleAvailable { get; }
        public uint HypervisorSleepStateSupportAvailable { get; }
        public uint NumaDistanceQueryAvailable { get; }
        public uint FrequencyRegsAvailable { get; }
        public uint SyntheticMachineCheckAvailable { get; }
        public uint GuestCrashRegsAvailable { get; }
        public uint DebugRegsAvailable { get; }
        public uint Npiep1Available { get; }
        public uint DisableHypervisorAvailable { get; }
        public uint ExtendedGvaRangesForFlushVirtualAddressListAvailable { get; }
        public uint FastHypercallOutputAvailable { get; }
        public uint PasidFeaturesAvailable { get; }
        public uint SintPollingModeAvailable { get; }
        public uint HypercallMsrLockAvailable { get; }
        public uint DirectSyntheticTimers { get; }
        public uint RegisterPatAvailable { get; }
        public uint RegisterBndcfgsAvailable { get; }
        public uint WatchdogTimerAvailable { get; }
        public uint SyntheticTimeUnhaltedTimerAvailable { get; }
        public uint DeviceDomainsAvailable { get; }
        public uint S1DeviceDomainsAvailable { get; }
        public uint LbrAvailable { get; }
        public uint IptAvailable { get; }
        public uint CrossVtlFlushAvailable { get; }
        public uint IdleSpecCtrlAvailable { get; }
        public uint TranslateGvaFlagsAvailable { get; }
        public uint ApicEoiInterceptAvailable { get; }

        public _HV_X64_HYPERVISOR_FEATURES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HV_X64_HYPERVISOR_FEATURES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.PartitionPrivileges),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.MaxSupportedCState),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.HpetNeededForC3PowerState_Deprecated),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.InvariantMperfAvailable),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.SupervisorShadowStackAvailable),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.ArchPmuAvailable),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.ExceptionTrapInterceptAvailable),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.VpDispatchInterruptInjectionAvailable),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.GhcbRootMappingAvailable),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.Reserved),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.MwaitAvailable_Deprecated),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.GuestDebuggingAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.PerformanceMonitorsAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.CpuDynamicPartitioningAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.XmmRegistersForFastHypercallAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.GuestIdleAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.HypervisorSleepStateSupportAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.NumaDistanceQueryAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.FrequencyRegsAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.SyntheticMachineCheckAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.GuestCrashRegsAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.DebugRegsAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.Npiep1Available),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.DisableHypervisorAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.ExtendedGvaRangesForFlushVirtualAddressListAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.FastHypercallOutputAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.PasidFeaturesAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.SintPollingModeAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.HypercallMsrLockAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.DirectSyntheticTimers),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.RegisterPatAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.RegisterBndcfgsAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.WatchdogTimerAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.SyntheticTimeUnhaltedTimerAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.DeviceDomainsAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.S1DeviceDomainsAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.LbrAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.IptAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.CrossVtlFlushAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.IdleSpecCtrlAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.TranslateGvaFlagsAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_HV_X64_HYPERVISOR_FEATURES.ApicEoiInterceptAvailable),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_HV_X64_HYPERVISOR_FEATURES>((mem, ptr) => new _HV_X64_HYPERVISOR_FEATURES(mem, ptr), offsets);
        }
    }
}