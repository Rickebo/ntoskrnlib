using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PARTITION_FLAGS")]
    public sealed class _MI_PARTITION_FLAGS : DynamicStructure
    {
        public uint BeingDeleted { get; }
        public uint PageListsInitialized { get; }
        public uint StoreReservedPagesCharged { get; }
        public uint UseProtectedSlabAllocators { get; }
        public uint PureHolding { get; }
        public uint ZeroPagesOptional { get; }
        public uint BackgroundZeroingDisabled { get; }
        public uint SpecialPurposeMemory { get; }
        public int EntireField { get; }

        public _MI_PARTITION_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PARTITION_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PARTITION_FLAGS.BeingDeleted),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PARTITION_FLAGS.PageListsInitialized),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PARTITION_FLAGS.StoreReservedPagesCharged),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PARTITION_FLAGS.UseProtectedSlabAllocators),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PARTITION_FLAGS.PureHolding),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PARTITION_FLAGS.ZeroPagesOptional),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PARTITION_FLAGS.BackgroundZeroingDisabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PARTITION_FLAGS.SpecialPurposeMemory),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PARTITION_FLAGS.EntireField),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_PARTITION_FLAGS>((mem, ptr) => new _MI_PARTITION_FLAGS(mem, ptr), offsets);
        }
    }
}