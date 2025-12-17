using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WHEA_EVENT_LOG_ENTRY_HEADER")]
    public sealed class _WHEA_EVENT_LOG_ENTRY_HEADER : DynamicStructure
    {
        public uint Signature { get; }
        public uint Version { get; }
        public uint Length { get; }
        public uint Type { get; }
        public uint OwnerTag { get; }
        public uint Id { get; }
        public _WHEA_EVENT_LOG_ENTRY_FLAGS Flags { get; }
        public uint PayloadLength { get; }

        public _WHEA_EVENT_LOG_ENTRY_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_EVENT_LOG_ENTRY_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_EVENT_LOG_ENTRY_HEADER.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_EVENT_LOG_ENTRY_HEADER.Version),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_WHEA_EVENT_LOG_ENTRY_HEADER.Length),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEA_EVENT_LOG_ENTRY_HEADER.Type),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_WHEA_EVENT_LOG_ENTRY_HEADER.OwnerTag),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEA_EVENT_LOG_ENTRY_HEADER.Id),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_WHEA_EVENT_LOG_ENTRY_HEADER.Flags),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WHEA_EVENT_LOG_ENTRY_HEADER.PayloadLength),
                    new ulong[]
                    {
                        28UL
                    }
                }
            };
            Register<_WHEA_EVENT_LOG_ENTRY_HEADER>((mem, ptr) => new _WHEA_EVENT_LOG_ENTRY_HEADER(mem, ptr), offsets);
        }
    }
}