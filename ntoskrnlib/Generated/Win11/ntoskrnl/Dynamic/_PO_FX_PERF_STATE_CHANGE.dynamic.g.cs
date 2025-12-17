using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PO_FX_PERF_STATE_CHANGE")]
    public sealed class _PO_FX_PERF_STATE_CHANGE : DynamicStructure
    {
        public uint Set { get; }
        public uint StateIndex { get; }
        public ulong StateValue { get; }

        public _PO_FX_PERF_STATE_CHANGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PO_FX_PERF_STATE_CHANGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PO_FX_PERF_STATE_CHANGE.Set),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PO_FX_PERF_STATE_CHANGE.StateIndex),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PO_FX_PERF_STATE_CHANGE.StateValue),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PO_FX_PERF_STATE_CHANGE>((mem, ptr) => new _PO_FX_PERF_STATE_CHANGE(mem, ptr), offsets);
        }
    }
}