using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_DEPENDENT")]
    public sealed class _POP_FX_DEPENDENT : DynamicStructure
    {
        public uint Index { get; }
        public uint ProviderIndex { get; }

        public _POP_FX_DEPENDENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_DEPENDENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_DEPENDENT.Index),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_DEPENDENT.ProviderIndex),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_POP_FX_DEPENDENT>((mem, ptr) => new _POP_FX_DEPENDENT(mem, ptr), offsets);
        }
    }
}