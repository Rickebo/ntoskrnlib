using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_MM_DRIVER_VERIFIER_DATA")]
    public sealed class _MM_DRIVER_VERIFIER_DATA : DynamicStructure
    {
        public uint Level { get; }
        public uint RaiseIrqls { get; }
        public uint AcquireSpinLocks { get; }
        public uint SynchronizeExecutions { get; }
        public uint AllocationsAttempted { get; }
        public uint AllocationsSucceeded { get; }
        public uint AllocationsSucceededSpecialPool { get; }
        public uint AllocationsWithNoTag { get; }
        public uint TrimRequests { get; }
        public uint Trims { get; }
        public uint AllocationsFailed { get; }
        public uint AllocationsFailedDeliberately { get; }
        public uint AllocationFreed { get; }
        public uint Loads { get; }
        public uint Unloads { get; }
        public uint UnTrackedPool { get; }
        public uint UserTrims { get; }
        public uint CurrentPagedPoolAllocations { get; }
        public uint CurrentNonPagedPoolAllocations { get; }
        public uint PeakPagedPoolAllocations { get; }
        public uint PeakNonPagedPoolAllocations { get; }
        public ulong PagedBytes { get; }
        public ulong NonPagedBytes { get; }
        public ulong PeakPagedBytes { get; }
        public ulong PeakNonPagedBytes { get; }
        public uint BurstAllocationsFailedDeliberately { get; }
        public uint SessionTrims { get; }
        public uint OptionChanges { get; }
        public uint VerifyMode { get; }
        public _UNICODE_STRING PreviousBucketName { get; }

        public _MM_DRIVER_VERIFIER_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MM_DRIVER_VERIFIER_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.Level),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.RaiseIrqls),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.AcquireSpinLocks),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.SynchronizeExecutions),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.AllocationsAttempted),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.AllocationsSucceeded),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.AllocationsSucceededSpecialPool),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.AllocationsWithNoTag),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.TrimRequests),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.Trims),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.AllocationsFailed),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.AllocationsFailedDeliberately),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.AllocationFreed),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.Loads),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.Unloads),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.UnTrackedPool),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.UserTrims),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.CurrentPagedPoolAllocations),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.CurrentNonPagedPoolAllocations),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.PeakPagedPoolAllocations),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.PeakNonPagedPoolAllocations),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.PagedBytes),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.NonPagedBytes),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.PeakPagedBytes),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.PeakNonPagedBytes),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.BurstAllocationsFailedDeliberately),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.SessionTrims),
                    new ulong[]
                    {
                        124UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.OptionChanges),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.VerifyMode),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_MM_DRIVER_VERIFIER_DATA.PreviousBucketName),
                    new ulong[]
                    {
                        136UL
                    }
                }
            };
            Register<_MM_DRIVER_VERIFIER_DATA>((mem, ptr) => new _MM_DRIVER_VERIFIER_DATA(mem, ptr), offsets);
        }
    }
}