using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_DPH_HEAP_BLOCK")]
    public sealed class _DPH_HEAP_BLOCK : DynamicStructure
    {
        public IntPtr pNextAlloc { get; }
        public _LIST_ENTRY AvailableEntry { get; }
        public _RTL_BALANCED_LINKS TableLinks { get; }
        public IntPtr pUserAllocation { get; }
        public IntPtr pVirtualBlock { get; }
        public ulong nVirtualBlockSize { get; }
        public ulong nVirtualAccessSize { get; }
        public ulong nUserRequestedSize { get; }
        public ulong nUserActualSize { get; }
        public IntPtr UserValue { get; }
        public uint UserFlags { get; }
        public IntPtr StackTrace { get; }
        public _LIST_ENTRY AdjacencyEntry { get; }
        public IntPtr pVirtualRegion { get; }

        public _DPH_HEAP_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DPH_HEAP_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DPH_HEAP_BLOCK.pNextAlloc),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DPH_HEAP_BLOCK.AvailableEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DPH_HEAP_BLOCK.TableLinks),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DPH_HEAP_BLOCK.pUserAllocation),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DPH_HEAP_BLOCK.pVirtualBlock),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_DPH_HEAP_BLOCK.nVirtualBlockSize),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_DPH_HEAP_BLOCK.nVirtualAccessSize),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_DPH_HEAP_BLOCK.nUserRequestedSize),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_DPH_HEAP_BLOCK.nUserActualSize),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_DPH_HEAP_BLOCK.UserValue),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_DPH_HEAP_BLOCK.UserFlags),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_DPH_HEAP_BLOCK.StackTrace),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_DPH_HEAP_BLOCK.AdjacencyEntry),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_DPH_HEAP_BLOCK.pVirtualRegion),
                    new ulong[]
                    {
                        120UL
                    }
                }
            };
            Register<_DPH_HEAP_BLOCK>((mem, ptr) => new _DPH_HEAP_BLOCK(mem, ptr), offsets);
        }
    }
}