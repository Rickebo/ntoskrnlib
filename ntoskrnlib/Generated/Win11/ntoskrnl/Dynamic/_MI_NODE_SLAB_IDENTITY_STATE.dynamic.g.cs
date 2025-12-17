using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_NODE_SLAB_IDENTITY_STATE")]
    public sealed class _MI_NODE_SLAB_IDENTITY_STATE : DynamicStructure
    {
        public byte[] SlabIdentityStandbyListCaches { get; }
        public byte[] SlabIdentityStandbyPageLists { get; }
        public byte[] SlabIdentityHints { get; }
        public byte[] SlabIdentityLists { get; }
        public _RTL_BITMAP SlabIdentityEmptyEntryBitmap { get; }
        public uint[] SlabIdentityEmptyEntryBitmapBuffer { get; }
        public _RTL_BITMAP SlabIdentityStandbyExistsBitmap { get; }
        public uint[] SlabIdentityStandbyExistsBitmapBuffer { get; }

        public _MI_NODE_SLAB_IDENTITY_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_NODE_SLAB_IDENTITY_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_NODE_SLAB_IDENTITY_STATE.SlabIdentityStandbyListCaches),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_NODE_SLAB_IDENTITY_STATE.SlabIdentityStandbyPageLists),
                    new ulong[]
                    {
                        266240UL
                    }
                },
                {
                    nameof(_MI_NODE_SLAB_IDENTITY_STATE.SlabIdentityHints),
                    new ulong[]
                    {
                        312000UL
                    }
                },
                {
                    nameof(_MI_NODE_SLAB_IDENTITY_STATE.SlabIdentityLists),
                    new ulong[]
                    {
                        313024UL
                    }
                },
                {
                    nameof(_MI_NODE_SLAB_IDENTITY_STATE.SlabIdentityEmptyEntryBitmap),
                    new ulong[]
                    {
                        314064UL
                    }
                },
                {
                    nameof(_MI_NODE_SLAB_IDENTITY_STATE.SlabIdentityEmptyEntryBitmapBuffer),
                    new ulong[]
                    {
                        314080UL
                    }
                },
                {
                    nameof(_MI_NODE_SLAB_IDENTITY_STATE.SlabIdentityStandbyExistsBitmap),
                    new ulong[]
                    {
                        314096UL
                    }
                },
                {
                    nameof(_MI_NODE_SLAB_IDENTITY_STATE.SlabIdentityStandbyExistsBitmapBuffer),
                    new ulong[]
                    {
                        314112UL
                    }
                }
            };
            Register<_MI_NODE_SLAB_IDENTITY_STATE>((mem, ptr) => new _MI_NODE_SLAB_IDENTITY_STATE(mem, ptr), offsets);
        }
    }
}