using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_AGGREGATED_PAYLOAD_FILTER")]
    public sealed class _AGGREGATED_PAYLOAD_FILTER : DynamicStructure
    {
        public ushort MagicValue { get; }
        public ushort DescriptorVersion { get; }
        public ushort Size { get; }
        public ushort PredicateCount { get; }
        public ushort Reserved { get; }
        public ulong HashedEventIdBitmap { get; }
        public _GUID ProviderGuid { get; }
        public ushort EachEventTableOffset { get; }
        public ushort EachEventTableLength { get; }
        public ushort PayloadDecoderTableOffset { get; }
        public ushort PayloadDecoderTableLength { get; }
        public ushort EventFilterTableOffset { get; }
        public ushort EventFilterTableLength { get; }
        public ushort UNICODEStringTableOffset { get; }
        public ushort UNICODEStringTableLength { get; }
        public ushort ANSIStringTableOffset { get; }
        public ushort ANSIStringTableLength { get; }
        public byte[] PredicateTable { get; }

        public _AGGREGATED_PAYLOAD_FILTER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _AGGREGATED_PAYLOAD_FILTER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_AGGREGATED_PAYLOAD_FILTER.MagicValue),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AGGREGATED_PAYLOAD_FILTER.DescriptorVersion),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AGGREGATED_PAYLOAD_FILTER.Size),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_AGGREGATED_PAYLOAD_FILTER.PredicateCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_AGGREGATED_PAYLOAD_FILTER.Reserved),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_AGGREGATED_PAYLOAD_FILTER.HashedEventIdBitmap),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_AGGREGATED_PAYLOAD_FILTER.ProviderGuid),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_AGGREGATED_PAYLOAD_FILTER.EachEventTableOffset),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_AGGREGATED_PAYLOAD_FILTER.EachEventTableLength),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_AGGREGATED_PAYLOAD_FILTER.PayloadDecoderTableOffset),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_AGGREGATED_PAYLOAD_FILTER.PayloadDecoderTableLength),
                    new ulong[]
                    {
                        38UL
                    }
                },
                {
                    nameof(_AGGREGATED_PAYLOAD_FILTER.EventFilterTableOffset),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_AGGREGATED_PAYLOAD_FILTER.EventFilterTableLength),
                    new ulong[]
                    {
                        42UL
                    }
                },
                {
                    nameof(_AGGREGATED_PAYLOAD_FILTER.UNICODEStringTableOffset),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_AGGREGATED_PAYLOAD_FILTER.UNICODEStringTableLength),
                    new ulong[]
                    {
                        46UL
                    }
                },
                {
                    nameof(_AGGREGATED_PAYLOAD_FILTER.ANSIStringTableOffset),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_AGGREGATED_PAYLOAD_FILTER.ANSIStringTableLength),
                    new ulong[]
                    {
                        50UL
                    }
                },
                {
                    nameof(_AGGREGATED_PAYLOAD_FILTER.PredicateTable),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_AGGREGATED_PAYLOAD_FILTER>((mem, ptr) => new _AGGREGATED_PAYLOAD_FILTER(mem, ptr), offsets);
        }
    }
}