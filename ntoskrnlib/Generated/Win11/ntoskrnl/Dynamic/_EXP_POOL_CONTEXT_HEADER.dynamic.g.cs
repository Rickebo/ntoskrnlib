using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXP_POOL_CONTEXT_HEADER")]
    public sealed class _EXP_POOL_CONTEXT_HEADER : DynamicStructure
    {
        public uint Signature { get; }
        public uint ContextType { get; }

        public _EXP_POOL_CONTEXT_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXP_POOL_CONTEXT_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXP_POOL_CONTEXT_HEADER.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXP_POOL_CONTEXT_HEADER.ContextType),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_EXP_POOL_CONTEXT_HEADER>((mem, ptr) => new _EXP_POOL_CONTEXT_HEADER(mem, ptr), offsets);
        }
    }
}