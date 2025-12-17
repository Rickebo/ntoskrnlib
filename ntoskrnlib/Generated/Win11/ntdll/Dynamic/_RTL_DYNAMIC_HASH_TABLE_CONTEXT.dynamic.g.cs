using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_DYNAMIC_HASH_TABLE_CONTEXT")]
    public sealed class _RTL_DYNAMIC_HASH_TABLE_CONTEXT : DynamicStructure
    {
        public IntPtr ChainHead { get; }
        public IntPtr PrevLinkage { get; }
        public ulong Signature { get; }

        public _RTL_DYNAMIC_HASH_TABLE_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_DYNAMIC_HASH_TABLE_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_DYNAMIC_HASH_TABLE_CONTEXT.ChainHead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_DYNAMIC_HASH_TABLE_CONTEXT.PrevLinkage),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_DYNAMIC_HASH_TABLE_CONTEXT.Signature),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_RTL_DYNAMIC_HASH_TABLE_CONTEXT>((mem, ptr) => new _RTL_DYNAMIC_HASH_TABLE_CONTEXT(mem, ptr), offsets);
        }
    }
}