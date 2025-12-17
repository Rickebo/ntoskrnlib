using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WHEA_ERROR_RECORD_HEADER_VALIDBITS")]
    public sealed class _WHEA_ERROR_RECORD_HEADER_VALIDBITS : DynamicStructure
    {
        public uint PlatformId { get; }
        public uint Timestamp { get; }
        public uint PartitionId { get; }
        public uint Reserved { get; }
        public uint AsULONG { get; }

        public _WHEA_ERROR_RECORD_HEADER_VALIDBITS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_ERROR_RECORD_HEADER_VALIDBITS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER_VALIDBITS.PlatformId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER_VALIDBITS.Timestamp),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER_VALIDBITS.PartitionId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER_VALIDBITS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER_VALIDBITS.AsULONG),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WHEA_ERROR_RECORD_HEADER_VALIDBITS>((mem, ptr) => new _WHEA_ERROR_RECORD_HEADER_VALIDBITS(mem, ptr), offsets);
        }
    }
}