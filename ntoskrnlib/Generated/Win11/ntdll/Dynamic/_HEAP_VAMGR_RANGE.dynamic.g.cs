using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_VAMGR_RANGE")]
    public sealed class _HEAP_VAMGR_RANGE : DynamicStructure
    {
        public _RTL_BALANCED_NODE RbNode { get; }
        public _SINGLE_LIST_ENTRY Next { get; }
        public byte Allocated { get; }
        public byte Internal { get; }
        public byte Standalone { get; }
        public byte Spare0 { get; }
        public byte AllocatorIndex { get; }
        public ushort CommitBitmap { get; }
        public ulong[] OwnerCtx { get; }
        public ulong SizeInChunks { get; }
        public ushort ChunkCount { get; }
        public ushort PrevChunkCount { get; }
        public ulong Signature { get; }

        public _HEAP_VAMGR_RANGE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_VAMGR_RANGE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_VAMGR_RANGE.RbNode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_RANGE.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_RANGE.Allocated),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_RANGE.Internal),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_RANGE.Standalone),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_RANGE.Spare0),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_RANGE.AllocatorIndex),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_RANGE.CommitBitmap),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_RANGE.OwnerCtx),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_RANGE.SizeInChunks),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_RANGE.ChunkCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_RANGE.PrevChunkCount),
                    new ulong[]
                    {
                        26UL
                    }
                },
                {
                    nameof(_HEAP_VAMGR_RANGE.Signature),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_HEAP_VAMGR_RANGE>((mem, ptr) => new _HEAP_VAMGR_RANGE(mem, ptr), offsets);
        }
    }
}