using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PNP_REBALANCE_TRACE_CONTEXT")]
    public sealed class _PNP_REBALANCE_TRACE_CONTEXT : DynamicStructure
    {
        public uint[] DeviceCount { get; }
        public uint RebalancePhase { get; }
        public uint Reason { get; }
        public uint[] Failure { get; }
        public byte[] SubtreeRoot { get; }
        public byte[] SubtreeIncludesRoot { get; }
        public IntPtr TriggerRoot { get; }
        public _PNP_REBALANCE_FLAGS Flags { get; }
        public ulong[] BeginTime { get; }
        public byte[] VetoNode { get; }
        public uint[] VetoQueryRebalanceReason { get; }
        public _PNP_RESOURCE_CONFLICT_TRACE_CONTEXT ConflictContext { get; }

        public _PNP_REBALANCE_TRACE_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PNP_REBALANCE_TRACE_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PNP_REBALANCE_TRACE_CONTEXT.DeviceCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PNP_REBALANCE_TRACE_CONTEXT.RebalancePhase),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PNP_REBALANCE_TRACE_CONTEXT.Reason),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_PNP_REBALANCE_TRACE_CONTEXT.Failure),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PNP_REBALANCE_TRACE_CONTEXT.SubtreeRoot),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PNP_REBALANCE_TRACE_CONTEXT.SubtreeIncludesRoot),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PNP_REBALANCE_TRACE_CONTEXT.TriggerRoot),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PNP_REBALANCE_TRACE_CONTEXT.Flags),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PNP_REBALANCE_TRACE_CONTEXT.BeginTime),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PNP_REBALANCE_TRACE_CONTEXT.VetoNode),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PNP_REBALANCE_TRACE_CONTEXT.VetoQueryRebalanceReason),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_PNP_REBALANCE_TRACE_CONTEXT.ConflictContext),
                    new ulong[]
                    {
                        104UL
                    }
                }
            };
            Register<_PNP_REBALANCE_TRACE_CONTEXT>((mem, ptr) => new _PNP_REBALANCE_TRACE_CONTEXT(mem, ptr), offsets);
        }
    }
}