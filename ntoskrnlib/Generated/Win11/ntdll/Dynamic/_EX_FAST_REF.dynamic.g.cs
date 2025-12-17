using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_EX_FAST_REF")]
    public sealed class _EX_FAST_REF : DynamicStructure
    {
        public IntPtr Object { get; }
        public ulong RefCnt { get; }
        public ulong Value { get; }

        public _EX_FAST_REF(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EX_FAST_REF()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EX_FAST_REF.Object),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_FAST_REF.RefCnt),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_FAST_REF.Value),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_EX_FAST_REF>((mem, ptr) => new _EX_FAST_REF(mem, ptr), offsets);
        }
    }
}