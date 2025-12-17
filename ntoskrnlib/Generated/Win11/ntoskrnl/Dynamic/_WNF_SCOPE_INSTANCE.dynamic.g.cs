using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WNF_SCOPE_INSTANCE")]
    public sealed class _WNF_SCOPE_INSTANCE : DynamicStructure
    {
        public _WNF_NODE_HEADER Header { get; }
        public _EX_RUNDOWN_REF RunRef { get; }
        public uint DataScope { get; }
        public uint InstanceIdSize { get; }
        public IntPtr InstanceIdData { get; }
        public _LIST_ENTRY ResolverListEntry { get; }
        public _WNF_LOCK NameSetLock { get; }
        public _RTL_AVL_TREE NameSet { get; }
        public IntPtr PermanentDataStore { get; }
        public IntPtr VolatilePermanentDataStore { get; }

        public _WNF_SCOPE_INSTANCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WNF_SCOPE_INSTANCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WNF_SCOPE_INSTANCE.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WNF_SCOPE_INSTANCE.RunRef),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WNF_SCOPE_INSTANCE.DataScope),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WNF_SCOPE_INSTANCE.InstanceIdSize),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_WNF_SCOPE_INSTANCE.InstanceIdData),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WNF_SCOPE_INSTANCE.ResolverListEntry),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WNF_SCOPE_INSTANCE.NameSetLock),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_WNF_SCOPE_INSTANCE.NameSet),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_WNF_SCOPE_INSTANCE.PermanentDataStore),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_WNF_SCOPE_INSTANCE.VolatilePermanentDataStore),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_WNF_SCOPE_INSTANCE>((mem, ptr) => new _WNF_SCOPE_INSTANCE(mem, ptr), offsets);
        }
    }
}