using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_ALPC_PROCESS_CONTEXT")]
    public sealed class _ALPC_PROCESS_CONTEXT : DynamicStructure
    {
        public _EX_PUSH_LOCK Lock { get; }
        public _LIST_ENTRY ViewListHead { get; }
        public ulong PagedPoolQuotaCache { get; }

        public _ALPC_PROCESS_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ALPC_PROCESS_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ALPC_PROCESS_CONTEXT.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ALPC_PROCESS_CONTEXT.ViewListHead),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ALPC_PROCESS_CONTEXT.PagedPoolQuotaCache),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_ALPC_PROCESS_CONTEXT>((mem, ptr) => new _ALPC_PROCESS_CONTEXT(mem, ptr), offsets);
        }
    }
}