using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WNF_PERMANENT_DATA_STORE")]
    public sealed class _WNF_PERMANENT_DATA_STORE : DynamicStructure
    {
        public _WNF_NODE_HEADER Header { get; }
        public _WNF_LOCK Lock { get; }
        public IntPtr Handle { get; }
        public _LIST_ENTRY Links { get; }
        public uint DataScopeType { get; }
        public uint ScopeInstanceIdSize { get; }

        public _WNF_PERMANENT_DATA_STORE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WNF_PERMANENT_DATA_STORE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WNF_PERMANENT_DATA_STORE.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WNF_PERMANENT_DATA_STORE.Lock),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WNF_PERMANENT_DATA_STORE.Handle),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WNF_PERMANENT_DATA_STORE.Links),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WNF_PERMANENT_DATA_STORE.DataScopeType),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_WNF_PERMANENT_DATA_STORE.ScopeInstanceIdSize),
                    new ulong[]
                    {
                        44UL
                    }
                }
            };
            Register<_WNF_PERMANENT_DATA_STORE>((mem, ptr) => new _WNF_PERMANENT_DATA_STORE(mem, ptr), offsets);
        }
    }
}