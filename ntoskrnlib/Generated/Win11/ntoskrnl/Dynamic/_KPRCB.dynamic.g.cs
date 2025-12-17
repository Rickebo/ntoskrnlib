using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KPRCB")]
    public sealed class _KPRCB : DynamicStructure
    {
        public uint MxCsr { get; }
        public byte LegacyNumber { get; }
        public byte ReservedMustBeZero { get; }
        public byte InterruptRequest { get; }
        public byte IdleHalt { get; }
        public IntPtr CurrentThread { get; }
        public IntPtr NextThread { get; }
        public IntPtr IdleThread { get; }
        public byte NestingLevel { get; }
        public byte ClockOwner { get; }
        public byte PendingTickFlags { get; }
        public byte PendingTick { get; }
        public byte PendingBackupTick { get; }
        public byte IdleState { get; }
        public uint Number { get; }
        public ulong RspBase { get; }
        public ulong PrcbLock { get; }
        public IntPtr PriorityState { get; }
        public sbyte CpuType { get; }
        public sbyte CpuID { get; }
        public ushort CpuStep { get; }
        public byte CpuStepping { get; }
        public byte CpuModel { get; }
        public uint MHz { get; }
        public ulong[] HalReserved { get; }
        public ushort MinorVersion { get; }
        public ushort MajorVersion { get; }
        public byte BuildType { get; }
        public byte CpuVendor { get; }
        public byte LegacyCoresPerPhysicalProcessor { get; }
        public byte LegacyLogicalProcessorsPerCore { get; }
        public ulong TscFrequency { get; }
        public IntPtr TracepointLog { get; }
        public uint CoresPerPhysicalProcessor { get; }
        public uint LogicalProcessorsPerCore { get; }
        public uint SelfIpiRequestSummary { get; }
        public byte QpcToTscIncrementShift { get; }
        public byte[] PrcbPad03 { get; }
        public ulong QpcToTscIncrement { get; }
        public ulong PrcbPad04 { get; }
        public IntPtr SchedulerSubNode { get; }
        public ulong GroupSetMember { get; }
        public byte Group { get; }
        public byte GroupIndex { get; }
        public byte[] PrcbPad05 { get; }
        public uint InitialApicId { get; }
        public uint ScbOffset { get; }
        public uint ApicMask { get; }
        public IntPtr AcpiReserved { get; }
        public uint CFlushSize { get; }
        public uint PrcbFlagsReserved { get; }
        public ulong[] PrcbPad11 { get; }
        public _KPROCESSOR_STATE ProcessorState { get; }
        public IntPtr ExtendedSupervisorState { get; }
        public uint ProcessorSignature { get; }
        public uint ProcessorFlags { get; }
        public ulong[] PrcbPad12a { get; }

        public _KPRCB(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KPRCB()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KPRCB.MxCsr),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRCB.LegacyNumber),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KPRCB.ReservedMustBeZero),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_KPRCB.InterruptRequest),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_KPRCB.IdleHalt),
                    new ulong[]
                    {
                        7UL
                    }
                },
                {
                    nameof(_KPRCB.CurrentThread),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KPRCB.NextThread),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KPRCB.IdleThread),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KPRCB.NestingLevel),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KPRCB.ClockOwner),
                    new ulong[]
                    {
                        33UL
                    }
                },
                {
                    nameof(_KPRCB.PendingTickFlags),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_KPRCB.PendingTick),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_KPRCB.PendingBackupTick),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_KPRCB.IdleState),
                    new ulong[]
                    {
                        35UL
                    }
                },
                {
                    nameof(_KPRCB.Number),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_KPRCB.RspBase),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbLock),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KPRCB.PriorityState),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_KPRCB.CpuType),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KPRCB.CpuID),
                    new ulong[]
                    {
                        65UL
                    }
                },
                {
                    nameof(_KPRCB.CpuStep),
                    new ulong[]
                    {
                        66UL
                    }
                },
                {
                    nameof(_KPRCB.CpuStepping),
                    new ulong[]
                    {
                        66UL
                    }
                },
                {
                    nameof(_KPRCB.CpuModel),
                    new ulong[]
                    {
                        67UL
                    }
                },
                {
                    nameof(_KPRCB.MHz),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_KPRCB.HalReserved),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_KPRCB.MinorVersion),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KPRCB.MajorVersion),
                    new ulong[]
                    {
                        138UL
                    }
                },
                {
                    nameof(_KPRCB.BuildType),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_KPRCB.CpuVendor),
                    new ulong[]
                    {
                        141UL
                    }
                },
                {
                    nameof(_KPRCB.LegacyCoresPerPhysicalProcessor),
                    new ulong[]
                    {
                        142UL
                    }
                },
                {
                    nameof(_KPRCB.LegacyLogicalProcessorsPerCore),
                    new ulong[]
                    {
                        143UL
                    }
                },
                {
                    nameof(_KPRCB.TscFrequency),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_KPRCB.TracepointLog),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_KPRCB.CoresPerPhysicalProcessor),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_KPRCB.LogicalProcessorsPerCore),
                    new ulong[]
                    {
                        164UL
                    }
                },
                {
                    nameof(_KPRCB.SelfIpiRequestSummary),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_KPRCB.QpcToTscIncrementShift),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad03),
                    new ulong[]
                    {
                        173UL
                    }
                },
                {
                    nameof(_KPRCB.QpcToTscIncrement),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad04),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_KPRCB.SchedulerSubNode),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_KPRCB.GroupSetMember),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_KPRCB.Group),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_KPRCB.GroupIndex),
                    new ulong[]
                    {
                        209UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad05),
                    new ulong[]
                    {
                        210UL
                    }
                },
                {
                    nameof(_KPRCB.InitialApicId),
                    new ulong[]
                    {
                        212UL
                    }
                },
                {
                    nameof(_KPRCB.ScbOffset),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_KPRCB.ApicMask),
                    new ulong[]
                    {
                        220UL
                    }
                },
                {
                    nameof(_KPRCB.AcpiReserved),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_KPRCB.CFlushSize),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbFlagsReserved),
                    new ulong[]
                    {
                        236UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad11),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_KPRCB.ProcessorState),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_KPRCB.ExtendedSupervisorState),
                    new ulong[]
                    {
                        1728UL
                    }
                },
                {
                    nameof(_KPRCB.ProcessorSignature),
                    new ulong[]
                    {
                        1736UL
                    }
                },
                {
                    nameof(_KPRCB.ProcessorFlags),
                    new ulong[]
                    {
                        1740UL
                    }
                },
                {
                    nameof(_KPRCB.PrcbPad12a),
                    new ulong[]
                    {
                        1744UL
                    }
                }
            };
            Register<_KPRCB>((mem, ptr) => new _KPRCB(mem, ptr), offsets);
        }
    }
}