using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DESCRIPTION_HEADER")]
    public sealed class _DESCRIPTION_HEADER : DynamicStructure
    {
        public uint Signature { get; }
        public uint Length { get; }
        public byte Revision { get; }
        public byte Checksum { get; }
        public sbyte[] OEMID { get; }
        public sbyte[] OEMTableID { get; }
        public uint OEMRevision { get; }
        public sbyte[] CreatorID { get; }
        public uint CreatorRev { get; }

        public _DESCRIPTION_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DESCRIPTION_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DESCRIPTION_HEADER.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DESCRIPTION_HEADER.Length),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DESCRIPTION_HEADER.Revision),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DESCRIPTION_HEADER.Checksum),
                    new ulong[]
                    {
                        9UL
                    }
                },
                {
                    nameof(_DESCRIPTION_HEADER.OEMID),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_DESCRIPTION_HEADER.OEMTableID),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DESCRIPTION_HEADER.OEMRevision),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DESCRIPTION_HEADER.CreatorID),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_DESCRIPTION_HEADER.CreatorRev),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_DESCRIPTION_HEADER>((mem, ptr) => new _DESCRIPTION_HEADER(mem, ptr), offsets);
        }
    }
}