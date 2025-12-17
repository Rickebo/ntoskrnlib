using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_LFH_FAST_REF")]
    public sealed class _HEAP_LFH_FAST_REF : DynamicStructure
    {
        public IntPtr Target { get; }
        public ulong Value { get; }
        public ulong RefCount { get; }

        public _HEAP_LFH_FAST_REF(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_FAST_REF()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_FAST_REF.Target),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_FAST_REF.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_FAST_REF.RefCount),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_LFH_FAST_REF>((mem, ptr) => new _HEAP_LFH_FAST_REF(mem, ptr), offsets);
        }
    }
}