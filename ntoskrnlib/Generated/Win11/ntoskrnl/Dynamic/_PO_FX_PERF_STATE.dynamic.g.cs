using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PO_FX_PERF_STATE")]
    public sealed class _PO_FX_PERF_STATE : DynamicStructure
    {
        public ulong Value { get; }
        public IntPtr Context { get; }

        public _PO_FX_PERF_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PO_FX_PERF_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PO_FX_PERF_STATE.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PO_FX_PERF_STATE.Context),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PO_FX_PERF_STATE>((mem, ptr) => new _PO_FX_PERF_STATE(mem, ptr), offsets);
        }
    }
}