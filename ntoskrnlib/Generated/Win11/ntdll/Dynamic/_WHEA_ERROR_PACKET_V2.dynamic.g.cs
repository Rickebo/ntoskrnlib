using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WHEA_ERROR_PACKET_V2")]
    public sealed class _WHEA_ERROR_PACKET_V2 : DynamicStructure
    {
        public uint Signature { get; }
        public uint Version { get; }
        public uint Length { get; }
        public _WHEA_ERROR_PACKET_FLAGS Flags { get; }
        public uint ErrorType { get; }
        public uint ErrorSeverity { get; }
        public uint ErrorSourceId { get; }
        public uint ErrorSourceType { get; }
        public _GUID NotifyType { get; }
        public ulong Context { get; }
        public uint DataFormat { get; }
        public uint Reserved1 { get; }
        public uint DataOffset { get; }
        public uint DataLength { get; }
        public uint PshedDataOffset { get; }
        public uint PshedDataLength { get; }

        public _WHEA_ERROR_PACKET_V2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_ERROR_PACKET_V2()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_ERROR_PACKET_V2.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_V2.Version),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_V2.Length),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_V2.Flags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_V2.ErrorType),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_V2.ErrorSeverity),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_V2.ErrorSourceId),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_V2.ErrorSourceType),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_V2.NotifyType),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_V2.Context),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_V2.DataFormat),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_V2.Reserved1),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_V2.DataOffset),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_V2.DataLength),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_V2.PshedDataOffset),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_V2.PshedDataLength),
                    new ulong[]
                    {
                        76UL
                    }
                }
            };
            Register<_WHEA_ERROR_PACKET_V2>((mem, ptr) => new _WHEA_ERROR_PACKET_V2(mem, ptr), offsets);
        }
    }
}