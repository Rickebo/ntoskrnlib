using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_VS_CONTEXT")]
    public sealed class _HEAP_VS_CONTEXT : DynamicStructure
    {
        public ushort SlotMapRef { get; }
        public byte AffinityMask { get; }
        public byte LockType { get; }
        public _RTL_HP_VS_CONFIG Config { get; }
        public byte EliminatePointers { get; }
        public short MemStatsOffset { get; }
        public IntPtr BackendCtx { get; }
        public _HEAP_SUBALLOCATOR_CALLBACKS Callbacks { get; }
        public _HEAP_AFFINITY_MGR AffinityMgr { get; }
        public ulong TotalCommittedUnits { get; }
        public ulong FreeCommittedUnits { get; }

        public _HEAP_VS_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_VS_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_VS_CONTEXT.SlotMapRef),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VS_CONTEXT.AffinityMask),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_HEAP_VS_CONTEXT.LockType),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_HEAP_VS_CONTEXT.Config),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HEAP_VS_CONTEXT.EliminatePointers),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_HEAP_VS_CONTEXT.MemStatsOffset),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_HEAP_VS_CONTEXT.BackendCtx),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_VS_CONTEXT.Callbacks),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_VS_CONTEXT.AffinityMgr),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_HEAP_VS_CONTEXT.TotalCommittedUnits),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_HEAP_VS_CONTEXT.FreeCommittedUnits),
                    new ulong[]
                    {
                        88UL
                    }
                }
            };
            Register<_HEAP_VS_CONTEXT>((mem, ptr) => new _HEAP_VS_CONTEXT(mem, ptr), offsets);
        }
    }
}