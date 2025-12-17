using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_VERIFIER_TRIM_STATE")]
    public sealed class _MI_VERIFIER_TRIM_STATE : DynamicStructure
    {
        public ulong StartTime { get; }
        public ulong ActualTrimTime { get; }
        public ulong MaximumSingleTrimTimeReached { get; }
        public uint Instances { get; }
        public int TrimInProgress { get; }

        public _MI_VERIFIER_TRIM_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_VERIFIER_TRIM_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_VERIFIER_TRIM_STATE.StartTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_VERIFIER_TRIM_STATE.ActualTrimTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_VERIFIER_TRIM_STATE.MaximumSingleTrimTimeReached),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_VERIFIER_TRIM_STATE.Instances),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_VERIFIER_TRIM_STATE.TrimInProgress),
                    new ulong[]
                    {
                        28UL
                    }
                }
            };
            Register<_MI_VERIFIER_TRIM_STATE>((mem, ptr) => new _MI_VERIFIER_TRIM_STATE(mem, ptr), offsets);
        }
    }
}