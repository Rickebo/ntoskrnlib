using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_GENERIC_ERROR_DESCRIPTOR")]
    public sealed class _WHEA_GENERIC_ERROR_DESCRIPTOR : DynamicStructure
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

        public _WHEA_GENERIC_ERROR_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_GENERIC_ERROR_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR.Reserved),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR.Enabled),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR.ErrStatusBlockLength),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR.RelatedErrorSourceId),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR.ErrStatusAddressSpaceID),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR.ErrStatusAddressBitWidth),
                    new ulong[]
                    {
                        13UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR.ErrStatusAddressBitOffset),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR.ErrStatusAddressAccessSize),
                    new ulong[]
                    {
                        15UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR.ErrStatusAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEA_GENERIC_ERROR_DESCRIPTOR.Notify),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_WHEA_GENERIC_ERROR_DESCRIPTOR>((mem, ptr) => new _WHEA_GENERIC_ERROR_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}