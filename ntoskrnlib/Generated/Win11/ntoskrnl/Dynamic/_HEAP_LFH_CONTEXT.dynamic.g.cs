using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_LFH_CONTEXT")]
    public sealed class _HEAP_LFH_CONTEXT : DynamicStructure
    {
        public IntPtr BackendCtx { get; }
        public _HEAP_SUBALLOCATOR_CALLBACKS Callbacks { get; }
        public IntPtr AffinityModArray { get; }
        public byte MaxAffinity { get; }
        public byte LockType { get; }
        public short MemStatsOffset { get; }
        public _HEAP_LFH_CONFIG Config { get; }
        public uint TlsSlotIndex { get; }
        public ulong EncodeKey { get; }
        public ulong ExtensionLock { get; }
        public byte[] MetadataList { get; }
        public _HEAP_LFH_HEAT_MAP HeatMap { get; }
        public byte[] Buckets { get; }
        public byte[] SlotMaps { get; }

        public _HEAP_LFH_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_CONTEXT.BackendCtx),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_CONTEXT.Callbacks),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_LFH_CONTEXT.AffinityModArray),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_HEAP_LFH_CONTEXT.MaxAffinity),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_HEAP_LFH_CONTEXT.LockType),
                    new ulong[]
                    {
                        65UL
                    }
                },
                {
                    nameof(_HEAP_LFH_CONTEXT.MemStatsOffset),
                    new ulong[]
                    {
                        66UL
                    }
                },
                {
                    nameof(_HEAP_LFH_CONTEXT.Config),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_HEAP_LFH_CONTEXT.TlsSlotIndex),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_HEAP_LFH_CONTEXT.EncodeKey),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_HEAP_LFH_CONTEXT.ExtensionLock),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_HEAP_LFH_CONTEXT.MetadataList),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_HEAP_LFH_CONTEXT.HeatMap),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_HEAP_LFH_CONTEXT.Buckets),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_HEAP_LFH_CONTEXT.SlotMaps),
                    new ulong[]
                    {
                        1472UL
                    }
                }
            };
            Register<_HEAP_LFH_CONTEXT>((mem, ptr) => new _HEAP_LFH_CONTEXT(mem, ptr), offsets);
        }
    }
}