using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HV_PARTITION_PRIVILEGE_MASK")]
    public sealed class _HV_PARTITION_PRIVILEGE_MASK : DynamicStructure
    {
        public ulong AsUINT64 { get; }
        public ulong AccessVpRunTimeReg { get; }
        public ulong AccessPartitionReferenceCounter { get; }
        public ulong AccessSynicRegs { get; }
        public ulong AccessSyntheticTimerRegs { get; }
        public ulong AccessIntrCtrlRegs { get; }
        public ulong AccessHypercallMsrs { get; }
        public ulong AccessVpIndex { get; }
        public ulong AccessResetReg { get; }
        public ulong AccessStatsReg { get; }
        public ulong AccessPartitionReferenceTsc { get; }
        public ulong AccessGuestIdleReg { get; }
        public ulong AccessFrequencyRegs { get; }
        public ulong AccessDebugRegs { get; }
        public ulong AccessReenlightenmentControls { get; }
        public ulong AccessRootSchedulerReg { get; }
        public ulong AccessTscInvariantControls { get; }
        public ulong Reserved1 { get; }
        public ulong CreatePartitions { get; }
        public ulong AccessPartitionId { get; }
        public ulong AccessMemoryPool { get; }
        public ulong AdjustMessageBuffers { get; }
        public ulong PostMessages { get; }
        public ulong SignalEvents { get; }
        public ulong CreatePort { get; }
        public ulong ConnectPort { get; }
        public ulong AccessStats { get; }
        public ulong Reserved2 { get; }
        public ulong Debugging { get; }
        public ulong CpuManagement { get; }
        public ulong ConfigureProfiler { get; }
        public ulong AccessVpExitTracing { get; }
        public ulong EnableExtendedGvaRangesForFlushVirtualAddressList { get; }
        public ulong AccessVsm { get; }
        public ulong AccessVpRegisters { get; }
        public ulong UnusedBit { get; }
        public ulong FastHypercallOutput { get; }
        public ulong EnableExtendedHypercalls { get; }
        public ulong StartVirtualProcessor { get; }
        public ulong Isolation { get; }
        public ulong Reserved3 { get; }

        public _HV_PARTITION_PRIVILEGE_MASK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HV_PARTITION_PRIVILEGE_MASK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AsUINT64),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessVpRunTimeReg),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessPartitionReferenceCounter),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessSynicRegs),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessSyntheticTimerRegs),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessIntrCtrlRegs),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessHypercallMsrs),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessVpIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessResetReg),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessStatsReg),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessPartitionReferenceTsc),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessGuestIdleReg),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessFrequencyRegs),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessDebugRegs),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessReenlightenmentControls),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessRootSchedulerReg),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessTscInvariantControls),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.Reserved1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.CreatePartitions),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessPartitionId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessMemoryPool),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AdjustMessageBuffers),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.PostMessages),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.SignalEvents),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.CreatePort),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.ConnectPort),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessStats),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.Reserved2),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.Debugging),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.CpuManagement),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.ConfigureProfiler),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessVpExitTracing),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.EnableExtendedGvaRangesForFlushVirtualAddressList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessVsm),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.AccessVpRegisters),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.UnusedBit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.FastHypercallOutput),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.EnableExtendedHypercalls),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.StartVirtualProcessor),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.Isolation),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_PARTITION_PRIVILEGE_MASK.Reserved3),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HV_PARTITION_PRIVILEGE_MASK>((mem, ptr) => new _HV_PARTITION_PRIVILEGE_MASK(mem, ptr), offsets);
        }
    }
}