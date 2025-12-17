using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PROBE_RAISE_TRACKER")]
    public sealed class _MI_PROBE_RAISE_TRACKER : DynamicStructure
    {
        public uint UserRangeInKernel { get; }
        public uint FaultFailed { get; }
        public uint WriteFaultFailed { get; }
        public uint LargePageFailed { get; }
        public uint UserAccessToKernelPte { get; }
        public uint BadPageLocation { get; }
        public uint InsufficientCharge { get; }
        public uint PageTableCharge { get; }
        public uint NoIoReference { get; }
        public uint ProbeFailed { get; }
        public uint PteIsZero { get; }
        public uint StrongCodeWrite { get; }
        public uint ReducedCloneCommitChargeFailed { get; }
        public uint CopyOnWriteAtDispatchNoPages { get; }
        public uint NoPageTablesAllowed { get; }
        public uint EnclavePageFailed { get; }

        public _MI_PROBE_RAISE_TRACKER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PROBE_RAISE_TRACKER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PROBE_RAISE_TRACKER.UserRangeInKernel),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PROBE_RAISE_TRACKER.FaultFailed),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MI_PROBE_RAISE_TRACKER.WriteFaultFailed),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_PROBE_RAISE_TRACKER.LargePageFailed),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MI_PROBE_RAISE_TRACKER.UserAccessToKernelPte),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_PROBE_RAISE_TRACKER.BadPageLocation),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_MI_PROBE_RAISE_TRACKER.InsufficientCharge),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_PROBE_RAISE_TRACKER.PageTableCharge),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_MI_PROBE_RAISE_TRACKER.NoIoReference),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_PROBE_RAISE_TRACKER.ProbeFailed),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_MI_PROBE_RAISE_TRACKER.PteIsZero),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_PROBE_RAISE_TRACKER.StrongCodeWrite),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_MI_PROBE_RAISE_TRACKER.ReducedCloneCommitChargeFailed),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MI_PROBE_RAISE_TRACKER.CopyOnWriteAtDispatchNoPages),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_MI_PROBE_RAISE_TRACKER.NoPageTablesAllowed),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MI_PROBE_RAISE_TRACKER.EnclavePageFailed),
                    new ulong[]
                    {
                        60UL
                    }
                }
            };
            Register<_MI_PROBE_RAISE_TRACKER>((mem, ptr) => new _MI_PROBE_RAISE_TRACKER(mem, ptr), offsets);
        }
    }
}