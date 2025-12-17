using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_STACK_TRACE_DATABASE")]
    public sealed class _STACK_TRACE_DATABASE : DynamicStructure
    {
        public sbyte[] Reserved { get; }
        public _RTL_STACK_DATABASE_LOCK Lock { get; }
        public IntPtr Reserved2 { get; }
        public ulong PeakHashCollisionListLength { get; }
        public IntPtr LowerMemoryStart { get; }
        public byte PreCommitted { get; }
        public byte DumpInProgress { get; }
        public IntPtr CommitBase { get; }
        public IntPtr CurrentLowerCommitLimit { get; }
        public IntPtr CurrentUpperCommitLimit { get; }
        public IntPtr NextFreeLowerMemory { get; }
        public IntPtr NextFreeUpperMemory { get; }
        public uint NumberOfEntriesLookedUp { get; }
        public uint NumberOfEntriesAdded { get; }
        public IntPtr EntryIndexArray { get; }
        public uint NumberOfEntriesAllocated { get; }
        public uint NumberOfEntriesAvailable { get; }
        public uint NumberOfAllocationFailures { get; }
        public byte[] FreeLists { get; }
        public uint NumberOfBuckets { get; }
        public byte[] Buckets { get; }

        public _STACK_TRACE_DATABASE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _STACK_TRACE_DATABASE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_STACK_TRACE_DATABASE.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.Reserved2),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.PeakHashCollisionListLength),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.LowerMemoryStart),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.PreCommitted),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.DumpInProgress),
                    new ulong[]
                    {
                        129UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.CommitBase),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.CurrentLowerCommitLimit),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.CurrentUpperCommitLimit),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.NextFreeLowerMemory),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.NextFreeUpperMemory),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.NumberOfEntriesLookedUp),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.NumberOfEntriesAdded),
                    new ulong[]
                    {
                        180UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.EntryIndexArray),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.NumberOfEntriesAllocated),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.NumberOfEntriesAvailable),
                    new ulong[]
                    {
                        196UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.NumberOfAllocationFailures),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.FreeLists),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.NumberOfBuckets),
                    new ulong[]
                    {
                        720UL
                    }
                },
                {
                    nameof(_STACK_TRACE_DATABASE.Buckets),
                    new ulong[]
                    {
                        728UL
                    }
                }
            };
            Register<_STACK_TRACE_DATABASE>((mem, ptr) => new _STACK_TRACE_DATABASE(mem, ptr), offsets);
        }
    }
}