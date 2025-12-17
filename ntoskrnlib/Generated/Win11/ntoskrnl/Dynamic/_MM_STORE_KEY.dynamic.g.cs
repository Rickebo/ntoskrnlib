using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MM_STORE_KEY")]
    public sealed class _MM_STORE_KEY : DynamicStructure
    {
        public uint EntireKey { get; }

        public _MM_STORE_KEY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MM_STORE_KEY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MM_STORE_KEY.EntireKey),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MM_STORE_KEY>((mem, ptr) => new _MM_STORE_KEY(mem, ptr), offsets);
        }
    }
}