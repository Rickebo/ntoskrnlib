using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXP_POOL_CONTEXT")]
    public sealed class _EXP_POOL_CONTEXT : DynamicStructure
    {
        public _EXP_POOL_CONTEXT_HEADER Header { get; }
        public RTL_HP_ENV_HANDLE EnvHandle { get; }
        public _EX_RUNDOWN_REF Rundown { get; }
        public _LIST_ENTRY PoolLink { get; }
        public ulong Tag { get; }
        public _UNICODE_STRING Name { get; }
        public uint NodeCount { get; }
        public byte[] Node { get; }

        public _EXP_POOL_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXP_POOL_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXP_POOL_CONTEXT.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXP_POOL_CONTEXT.EnvHandle),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EXP_POOL_CONTEXT.Rundown),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_EXP_POOL_CONTEXT.PoolLink),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_EXP_POOL_CONTEXT.Tag),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_EXP_POOL_CONTEXT.Name),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_EXP_POOL_CONTEXT.NodeCount),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_EXP_POOL_CONTEXT.Node),
                    new ulong[]
                    {
                        80UL
                    }
                }
            };
            Register<_EXP_POOL_CONTEXT>((mem, ptr) => new _EXP_POOL_CONTEXT(mem, ptr), offsets);
        }
    }
}