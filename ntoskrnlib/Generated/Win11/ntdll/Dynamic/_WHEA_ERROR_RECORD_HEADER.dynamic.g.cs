using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WHEA_ERROR_RECORD_HEADER")]
    public sealed class _WHEA_ERROR_RECORD_HEADER : DynamicStructure
    {
        public uint Signature { get; }
        public _WHEA_REVISION Revision { get; }
        public uint SignatureEnd { get; }
        public ushort SectionCount { get; }
        public uint Severity { get; }
        public _WHEA_ERROR_RECORD_HEADER_VALIDBITS ValidBits { get; }
        public uint Length { get; }
        public _WHEA_TIMESTAMP Timestamp { get; }
        public _GUID PlatformId { get; }
        public _GUID PartitionId { get; }
        public _GUID CreatorId { get; }
        public _GUID NotifyType { get; }
        public ulong RecordId { get; }
        public _WHEA_ERROR_RECORD_HEADER_FLAGS Flags { get; }
        public _WHEA_PERSISTENCE_INFO PersistenceInfo { get; }
        public uint OsBuildNumber { get; }
        public byte[] Reserved2 { get; }
        public byte[] Reserved { get; }

        public _WHEA_ERROR_RECORD_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_ERROR_RECORD_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER.Revision),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER.SignatureEnd),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER.SectionCount),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER.Severity),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER.ValidBits),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER.Length),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER.Timestamp),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER.PlatformId),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER.PartitionId),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER.CreatorId),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER.NotifyType),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER.RecordId),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER.Flags),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER.PersistenceInfo),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER.OsBuildNumber),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER.Reserved2),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_HEADER.Reserved),
                    new ulong[]
                    {
                        116UL
                    }
                }
            };
            Register<_WHEA_ERROR_RECORD_HEADER>((mem, ptr) => new _WHEA_ERROR_RECORD_HEADER(mem, ptr), offsets);
        }
    }
}