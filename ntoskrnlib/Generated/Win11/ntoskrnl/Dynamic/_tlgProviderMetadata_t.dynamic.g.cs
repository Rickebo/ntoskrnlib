using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_tlgProviderMetadata_t")]
    public sealed class _tlgProviderMetadata_t : DynamicStructure
    {
        public byte Type { get; }
        public _GUID ProviderId { get; }
        public ushort RemainingSize { get; }

        public _tlgProviderMetadata_t(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _tlgProviderMetadata_t()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_tlgProviderMetadata_t.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_tlgProviderMetadata_t.ProviderId),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_tlgProviderMetadata_t.RemainingSize),
                    new ulong[]
                    {
                        17UL
                    }
                }
            };
            Register<_tlgProviderMetadata_t>((mem, ptr) => new _tlgProviderMetadata_t(mem, ptr), offsets);
        }
    }
}