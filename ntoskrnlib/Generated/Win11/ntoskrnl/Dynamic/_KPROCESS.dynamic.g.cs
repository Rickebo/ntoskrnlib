using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KPROCESS")]
    public sealed class _KPROCESS : DynamicStructure
    {
        public _DISPATCHER_HEADER Header { get; }
        public _LIST_ENTRY ProfileListHead { get; }
        public ulong DirectoryTableBase { get; }
        public _LIST_ENTRY ThreadListHead { get; }
        public uint ProcessLock { get; }
        public uint ProcessTimerDelay { get; }
        public ulong DeepFreezeStartTime { get; }
        public IntPtr Affinity { get; }
        public _KAB_UM_PROCESS_CONTEXT AutoBoostState { get; }
        public _LIST_ENTRY ReadyListHead { get; }
        public _SINGLE_LIST_ENTRY SwapListEntry { get; }
        public IntPtr ActiveProcessors { get; }
        public uint AutoAlignment { get; }
        public uint DisableBoost { get; }
        public uint DisableQuantum { get; }
        public uint DeepFreeze { get; }
        public uint TimerVirtualization { get; }
        public uint CheckStackExtents { get; }
        public uint CacheIsolationEnabled { get; }
        public uint PpmPolicy { get; }
        public uint VaSpaceDeleted { get; }
        public uint MultiGroup { get; }
        public uint ForegroundProcess { get; }
        public uint ReservedFlags { get; }
        public int ProcessFlags { get; }
        public uint Spare0c { get; }
        public sbyte BasePriority { get; }
        public sbyte QuantumReset { get; }
        public sbyte Visited { get; }
        public _KEXECUTE_OPTIONS Flags { get; }
        public _KGROUP_MASK ActiveGroupsMask { get; }
        public ulong[] ActiveGroupPadding { get; }
        public IntPtr IdealProcessorAssignmentBlock { get; }
        public ulong[] Padding { get; }
        public uint Padding2 { get; }
        public uint SchedulerAssistYieldBoostCount { get; }
        public long SchedulerAssistYieldBoostAllowedTime { get; }
        public uint Spare0d { get; }
        public ushort IdealGlobalNode { get; }
        public ushort Spare1 { get; }
        public _KSTACK_COUNT StackCount { get; }
        public _LIST_ENTRY ProcessListEntry { get; }
        public ulong CycleTime { get; }
        public ulong ContextSwitches { get; }
        public IntPtr SchedulingGroup { get; }
        public ulong KernelTime { get; }
        public ulong UserTime { get; }
        public ulong ReadyTime { get; }
        public uint FreezeCount { get; }
        public uint Spare4 { get; }
        public ulong UserDirectoryTableBase { get; }
        public byte AddressPolicy { get; }
        public byte[] Spare2 { get; }
        public IntPtr InstrumentationCallback { get; }
        public _unnamed_tag_ SecureState { get; }
        public ulong KernelWaitTime { get; }
        public ulong UserWaitTime { get; }
        public ulong LastRebalanceQpc { get; }
        public IntPtr PerProcessorCycleTimes { get; }
        public ulong ExtendedFeatureDisableMask { get; }
        public ushort PrimaryGroup { get; }
        public ushort[] Spare3 { get; }
        public IntPtr UserCetLogging { get; }
        public _LIST_ENTRY CpuPartitionList { get; }
        public IntPtr AvailableCpuState { get; }

        public _KPROCESS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KPROCESS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KPROCESS.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPROCESS.ProfileListHead),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KPROCESS.DirectoryTableBase),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KPROCESS.ThreadListHead),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KPROCESS.ProcessLock),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KPROCESS.ProcessTimerDelay),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_KPROCESS.DeepFreezeStartTime),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_KPROCESS.Affinity),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_KPROCESS.AutoBoostState),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_KPROCESS.ReadyListHead),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_KPROCESS.SwapListEntry),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KPROCESS.ActiveProcessors),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_KPROCESS.AutoAlignment),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KPROCESS.DisableBoost),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KPROCESS.DisableQuantum),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KPROCESS.DeepFreeze),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KPROCESS.TimerVirtualization),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KPROCESS.CheckStackExtents),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KPROCESS.CacheIsolationEnabled),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KPROCESS.PpmPolicy),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KPROCESS.VaSpaceDeleted),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KPROCESS.MultiGroup),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KPROCESS.ForegroundProcess),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KPROCESS.ReservedFlags),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KPROCESS.ProcessFlags),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KPROCESS.Spare0c),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_KPROCESS.BasePriority),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_KPROCESS.QuantumReset),
                    new ulong[]
                    {
                        145UL
                    }
                },
                {
                    nameof(_KPROCESS.Visited),
                    new ulong[]
                    {
                        146UL
                    }
                },
                {
                    nameof(_KPROCESS.Flags),
                    new ulong[]
                    {
                        147UL
                    }
                },
                {
                    nameof(_KPROCESS.ActiveGroupsMask),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_KPROCESS.ActiveGroupPadding),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_KPROCESS.IdealProcessorAssignmentBlock),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_KPROCESS.Padding),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_KPROCESS.Padding2),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_KPROCESS.SchedulerAssistYieldBoostCount),
                    new ulong[]
                    {
                        244UL
                    }
                },
                {
                    nameof(_KPROCESS.SchedulerAssistYieldBoostAllowedTime),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_KPROCESS.Spare0d),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_KPROCESS.IdealGlobalNode),
                    new ulong[]
                    {
                        260UL
                    }
                },
                {
                    nameof(_KPROCESS.Spare1),
                    new ulong[]
                    {
                        262UL
                    }
                },
                {
                    nameof(_KPROCESS.StackCount),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_KPROCESS.ProcessListEntry),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_KPROCESS.CycleTime),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_KPROCESS.ContextSwitches),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_KPROCESS.SchedulingGroup),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_KPROCESS.KernelTime),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_KPROCESS.UserTime),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_KPROCESS.ReadyTime),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_KPROCESS.FreezeCount),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_KPROCESS.Spare4),
                    new ulong[]
                    {
                        340UL
                    }
                },
                {
                    nameof(_KPROCESS.UserDirectoryTableBase),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_KPROCESS.AddressPolicy),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_KPROCESS.Spare2),
                    new ulong[]
                    {
                        353UL
                    }
                },
                {
                    nameof(_KPROCESS.InstrumentationCallback),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_KPROCESS.SecureState),
                    new ulong[]
                    {
                        368UL
                    }
                },
                {
                    nameof(_KPROCESS.KernelWaitTime),
                    new ulong[]
                    {
                        376UL
                    }
                },
                {
                    nameof(_KPROCESS.UserWaitTime),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_KPROCESS.LastRebalanceQpc),
                    new ulong[]
                    {
                        392UL
                    }
                },
                {
                    nameof(_KPROCESS.PerProcessorCycleTimes),
                    new ulong[]
                    {
                        400UL
                    }
                },
                {
                    nameof(_KPROCESS.ExtendedFeatureDisableMask),
                    new ulong[]
                    {
                        408UL
                    }
                },
                {
                    nameof(_KPROCESS.PrimaryGroup),
                    new ulong[]
                    {
                        416UL
                    }
                },
                {
                    nameof(_KPROCESS.Spare3),
                    new ulong[]
                    {
                        418UL
                    }
                },
                {
                    nameof(_KPROCESS.UserCetLogging),
                    new ulong[]
                    {
                        424UL
                    }
                },
                {
                    nameof(_KPROCESS.CpuPartitionList),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(_KPROCESS.AvailableCpuState),
                    new ulong[]
                    {
                        448UL
                    }
                }
            };
            Register<_KPROCESS>((mem, ptr) => new _KPROCESS(mem, ptr), offsets);
        }
    }
}