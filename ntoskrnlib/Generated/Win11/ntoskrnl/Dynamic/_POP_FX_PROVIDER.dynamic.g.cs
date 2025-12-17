using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_PROVIDER")]
    public sealed class _POP_FX_PROVIDER : DynamicStructure
    {
        public uint Index { get; }
        public byte Activating { get; }

        public _POP_FX_PROVIDER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_PROVIDER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_PROVIDER.Index),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_PROVIDER.Activating),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_POP_FX_PROVIDER>((mem, ptr) => new _POP_FX_PROVIDER(mem, ptr), offsets);
        }
    }
}