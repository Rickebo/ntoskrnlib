using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WHEA_GENERIC_ERROR_DESCRIPTOR_V2")]
    public sealed class _WHEA_GENERIC_ERROR_DESCRIPTOR_V2 : DynamicStructure
    {
        public ushort Type { get; }
        public byte Reserved { get; }
        public byte Enabled { get; }
        public uint ErrStatusBlockLength { get; }
        public uint RelatedErrorSourceId { get; }
        public byte ErrStatusAddressSpaceID { get; }
        public byte ErrStatusAddressBitWidth { get; }
        public byte ErrStatusAddressBitOffset { get; }
        public byte ErrStatusAddressAccessSize { get; }
        public _LARGE_INTEGER ErrStatusAddress { get; }
        public _WHEA_NOTIFICATION_DESCRIPTOR Notify { get; }
        public byte ReadAckAddressSpaceID { get; }
        public byte ReadAckAddressBitWidth { get; }
        public byte ReadAckAddressBitOffset { get; }
        public byte ReadAckAddressAccessSize { get; }
        public _LARGE_INTEGER ReadAckAddress { get; }
        public ulong ReadAckPreserveMask { get; }
        public ulong ReadAckWriteMask { get; }

        public _WHEA_GENERIC_ERROR_DESCRIPTOR_V2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_GENERIC_ERROR_DESCRIPTOR_V2()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR_V2.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR_V2.Reserved),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR_V2.Enabled),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR_V2.ErrStatusBlockLength),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR_V2.RelatedErrorSourceId),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR_V2.ErrStatusAddressSpaceID),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR_V2.ErrStatusAddressBitWidth),
                    new ulong[]
                    {
                        13UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR_V2.ErrStatusAddressBitOffset),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR_V2.ErrStatusAddressAccessSize),
                    new ulong[]
                    {
                        15UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR_V2.ErrStatusAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR_V2.Notify),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR_V2.ReadAckAddressSpaceID),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR_V2.ReadAckAddressBitWidth),
                    new ulong[]
                    {
                        53UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR_V2.ReadAckAddressBitOffset),
                    new ulong[]
                    {
                        54UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR_V2.ReadAckAddressAccessSize),
                    new ulong[]
                    {
                        55UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR_V2.ReadAckAddress),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR_V2.ReadAckPreserveMask),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR_V2.ReadAckWriteMask),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_WHEA_GENERIC_ERROR_DESCRIPTOR_V2>((mem, ptr) => new _WHEA_GENERIC_ERROR_DESCRIPTOR_V2(mem, ptr), offsets);
        }
    }
}