using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HAL_INTEL_ENLIGHTENMENT_INFORMATION")]
    public sealed class _HAL_INTEL_ENLIGHTENMENT_INFORMATION : DynamicStructure
    {
        public uint Enlightenments { get; }
        public uint HypervisorConnected { get; }
        public IntPtr EndOfInterrupt { get; }
        public IntPtr ApicWriteIcr { get; }
        public uint Reserved0 { get; }
        public uint SpinCountMask { get; }
        public IntPtr LongSpinWait { get; }
        public IntPtr GetReferenceTime { get; }
        public IntPtr SetSystemSleepProperty { get; }
        public IntPtr EnterSleepState { get; }
        public IntPtr NotifyDebugDeviceAvailable { get; }
        public IntPtr MapDeviceInterrupt { get; }
        public IntPtr UnmapDeviceInterrupt { get; }
        public IntPtr RetargetDeviceInterrupt { get; }
        public IntPtr SetHpetConfig { get; }
        public IntPtr NotifyHpetEnabled { get; }
        public IntPtr QueryAssociatedProcessors { get; }
        public IntPtr ReadMultipleMsr { get; }
        public IntPtr WriteMultipleMsr { get; }
        public IntPtr ReadCpuid { get; }
        public IntPtr LpWritebackInvalidate { get; }
        public IntPtr GetMachineCheckContext { get; }
        public IntPtr SuspendPartition { get; }
        public IntPtr ResumePartition { get; }
        public IntPtr SetSystemMachineCheckProperty { get; }
        public IntPtr WheaErrorNotification { get; }
        public IntPtr GetProcessorIndexFromVpIndex { get; }
        public IntPtr SyntheticClusterIpi { get; }
        public IntPtr VpStartEnabled { get; }
        public IntPtr StartVirtualProcessor { get; }
        public IntPtr GetVpIndexFromApicId { get; }
        public IntPtr IumAccessPciDevice { get; }
        public IntPtr IumEfiRuntimeService { get; }
        public IntPtr GetSystemPasidCapabilities { get; }
        public IntPtr GetDeviceCapabilities { get; }
        public IntPtr CreatePasidSpace { get; }
        public IntPtr SetPasidAddressSpace { get; }
        public IntPtr FlushPasid { get; }
        public IntPtr AttachPasidSpace { get; }
        public IntPtr DetachPasidSpace { get; }
        public IntPtr EnablePasid { get; }
        public IntPtr DisablePasid { get; }
        public IntPtr AcknowledgePageRequest { get; }
        public IntPtr CreatePrQueue { get; }
        public IntPtr DeletePrQueue { get; }
        public IntPtr ClearPrqStalled { get; }
        public IntPtr SetDeviceDmaEnabled { get; }
        public IntPtr SetDeviceCapabilities { get; }
        public IntPtr AttachPrQueue { get; }
        public IntPtr DetachPrQueue { get; }
        public IntPtr HvDebuggerPowerHandler { get; }
        public IntPtr SetQpcBias { get; }
        public IntPtr GetQpcBias { get; }
        public IntPtr RegisterDeviceId { get; }
        public IntPtr UnregisterDeviceId { get; }
        public IntPtr AllocateDeviceDomain { get; }
        public IntPtr AttachDeviceDomain { get; }
        public IntPtr DetachDeviceDomain { get; }
        public IntPtr DeleteDeviceDomain { get; }
        public IntPtr MapDeviceLogicalRange { get; }
        public IntPtr UnmapDeviceLogicalRange { get; }
        public IntPtr MapDeviceSparsePages { get; }
        public IntPtr UnmapDeviceSparsePages { get; }
        public IntPtr GetDmaGuardEnabled { get; }
        public IntPtr UpdateMicrocode { get; }
        public IntPtr GetMicrocodeLatency { get; }
        public IntPtr GetSintMessage { get; }
        public IntPtr GetSintMessagePage { get; }
        public IntPtr RestoreTime { get; }
        public IntPtr GetLogicalProcessorHwId { get; }
        public IntPtr WakeVirtualProcessors { get; }
        public IntPtr SetRootFaultReportingReady { get; }
        public IntPtr ConfigureDeviceDomain { get; }
        public IntPtr UnblockDefaultDma { get; }
        public IntPtr FlushDeviceDomain { get; }
        public IntPtr FlushDeviceDomainVaList { get; }
        public IntPtr GetHybridPassthroughReservedRegions { get; }
        public IntPtr ReserveDeviceDomainAttachment { get; }
        public IntPtr UnreserveDeviceDomainAttachment { get; }
        public IntPtr ChangeIsolatedMemoryVisibility { get; }

        public _HAL_INTEL_ENLIGHTENMENT_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HAL_INTEL_ENLIGHTENMENT_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.Enlightenments),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.HypervisorConnected),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.EndOfInterrupt),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.ApicWriteIcr),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.Reserved0),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.SpinCountMask),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.LongSpinWait),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.GetReferenceTime),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.SetSystemSleepProperty),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.EnterSleepState),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.NotifyDebugDeviceAvailable),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.MapDeviceInterrupt),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.UnmapDeviceInterrupt),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.RetargetDeviceInterrupt),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.SetHpetConfig),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.NotifyHpetEnabled),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.QueryAssociatedProcessors),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.ReadMultipleMsr),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.WriteMultipleMsr),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.ReadCpuid),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.LpWritebackInvalidate),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.GetMachineCheckContext),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.SuspendPartition),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.ResumePartition),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.SetSystemMachineCheckProperty),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.WheaErrorNotification),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.GetProcessorIndexFromVpIndex),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.SyntheticClusterIpi),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.VpStartEnabled),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.StartVirtualProcessor),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.GetVpIndexFromApicId),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.IumAccessPciDevice),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.IumEfiRuntimeService),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.GetSystemPasidCapabilities),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.GetDeviceCapabilities),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.CreatePasidSpace),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.SetPasidAddressSpace),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.FlushPasid),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.AttachPasidSpace),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.DetachPasidSpace),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.EnablePasid),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.DisablePasid),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.AcknowledgePageRequest),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.CreatePrQueue),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.DeletePrQueue),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.ClearPrqStalled),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.SetDeviceDmaEnabled),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.SetDeviceCapabilities),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.AttachPrQueue),
                    new ulong[]
                    {
                        368UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.DetachPrQueue),
                    new ulong[]
                    {
                        376UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.HvDebuggerPowerHandler),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.SetQpcBias),
                    new ulong[]
                    {
                        392UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.GetQpcBias),
                    new ulong[]
                    {
                        400UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.RegisterDeviceId),
                    new ulong[]
                    {
                        408UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.UnregisterDeviceId),
                    new ulong[]
                    {
                        416UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.AllocateDeviceDomain),
                    new ulong[]
                    {
                        424UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.AttachDeviceDomain),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.DetachDeviceDomain),
                    new ulong[]
                    {
                        440UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.DeleteDeviceDomain),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.MapDeviceLogicalRange),
                    new ulong[]
                    {
                        456UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.UnmapDeviceLogicalRange),
                    new ulong[]
                    {
                        464UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.MapDeviceSparsePages),
                    new ulong[]
                    {
                        472UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.UnmapDeviceSparsePages),
                    new ulong[]
                    {
                        480UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.GetDmaGuardEnabled),
                    new ulong[]
                    {
                        488UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.UpdateMicrocode),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.GetMicrocodeLatency),
                    new ulong[]
                    {
                        504UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.GetSintMessage),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.GetSintMessagePage),
                    new ulong[]
                    {
                        520UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.RestoreTime),
                    new ulong[]
                    {
                        528UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.GetLogicalProcessorHwId),
                    new ulong[]
                    {
                        536UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.WakeVirtualProcessors),
                    new ulong[]
                    {
                        544UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.SetRootFaultReportingReady),
                    new ulong[]
                    {
                        552UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.ConfigureDeviceDomain),
                    new ulong[]
                    {
                        560UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.UnblockDefaultDma),
                    new ulong[]
                    {
                        568UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.FlushDeviceDomain),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.FlushDeviceDomainVaList),
                    new ulong[]
                    {
                        584UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.GetHybridPassthroughReservedRegions),
                    new ulong[]
                    {
                        592UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.ReserveDeviceDomainAttachment),
                    new ulong[]
                    {
                        600UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.UnreserveDeviceDomainAttachment),
                    new ulong[]
                    {
                        608UL
                    }
                },
                {
                    nameof(_HAL_INTEL_ENLIGHTENMENT_INFORMATION.ChangeIsolatedMemoryVisibility),
                    new ulong[]
                    {
                        616UL
                    }
                }
            };
            Register<_HAL_INTEL_ENLIGHTENMENT_INFORMATION>((mem, ptr) => new _HAL_INTEL_ENLIGHTENMENT_INFORMATION(mem, ptr), offsets);
        }
    }
}