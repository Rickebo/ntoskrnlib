using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HALP_DMA_DOMAIN_OBJECT")]
    public sealed class _HALP_DMA_DOMAIN_OBJECT : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public _LARGE_INTEGER MaximumPhysicalAddress { get; }
        public _LARGE_INTEGER BoundaryAddressMultiple { get; }
        public byte CacheCoherent { get; }
        public byte FirmwareReserved { get; }
        public IntPtr IommuDomainPointer { get; }
        public uint TranslationType { get; }
        public IntPtr OwningAdapter { get; }
        public _RTL_RB_TREE CommonBufferRoot { get; }
        public ulong CommonBufferTreeLock { get; }
        public _LIST_ENTRY VectorCommonBufferListHead { get; }
        public ulong VectorCommonBufferLock { get; }
        public uint DomainRefCount { get; }

        public _HALP_DMA_DOMAIN_OBJECT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HALP_DMA_DOMAIN_OBJECT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HALP_DMA_DOMAIN_OBJECT.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HALP_DMA_DOMAIN_OBJECT.MaximumPhysicalAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HALP_DMA_DOMAIN_OBJECT.BoundaryAddressMultiple),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HALP_DMA_DOMAIN_OBJECT.CacheCoherent),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HALP_DMA_DOMAIN_OBJECT.FirmwareReserved),
                    new ulong[]
                    {
                        33UL
                    }
                },
                {
                    nameof(_HALP_DMA_DOMAIN_OBJECT.IommuDomainPointer),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HALP_DMA_DOMAIN_OBJECT.TranslationType),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_HALP_DMA_DOMAIN_OBJECT.OwningAdapter),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_HALP_DMA_DOMAIN_OBJECT.CommonBufferRoot),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_HALP_DMA_DOMAIN_OBJECT.CommonBufferTreeLock),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_HALP_DMA_DOMAIN_OBJECT.VectorCommonBufferListHead),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_HALP_DMA_DOMAIN_OBJECT.VectorCommonBufferLock),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_HALP_DMA_DOMAIN_OBJECT.DomainRefCount),
                    new ulong[]
                    {
                        112UL
                    }
                }
            };
            Register<_HALP_DMA_DOMAIN_OBJECT>((mem, ptr) => new _HALP_DMA_DOMAIN_OBJECT(mem, ptr), offsets);
        }
    }
}