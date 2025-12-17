using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SMBIOS3_TABLE_HEADER")]
    public sealed class _SMBIOS3_TABLE_HEADER : DynamicStructure
    {
        public byte[] Signature { get; }
        public byte Checksum { get; }
        public byte Length { get; }
        public byte MajorVersion { get; }
        public byte MinorVersion { get; }
        public byte Docrev { get; }
        public byte EntryPointRevision { get; }
        public byte Reserved { get; }
        public uint StructureTableMaximumSize { get; }
        public ulong StructureTableAddress { get; }

        public _SMBIOS3_TABLE_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SMBIOS3_TABLE_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SMBIOS3_TABLE_HEADER.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SMBIOS3_TABLE_HEADER.Checksum),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_SMBIOS3_TABLE_HEADER.Length),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_SMBIOS3_TABLE_HEADER.MajorVersion),
                    new ulong[]
                    {
                        7UL
                    }
                },
                {
                    nameof(_SMBIOS3_TABLE_HEADER.MinorVersion),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SMBIOS3_TABLE_HEADER.Docrev),
                    new ulong[]
                    {
                        9UL
                    }
                },
                {
                    nameof(_SMBIOS3_TABLE_HEADER.EntryPointRevision),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_SMBIOS3_TABLE_HEADER.Reserved),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(_SMBIOS3_TABLE_HEADER.StructureTableMaximumSize),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_SMBIOS3_TABLE_HEADER.StructureTableAddress),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_SMBIOS3_TABLE_HEADER>((mem, ptr) => new _SMBIOS3_TABLE_HEADER(mem, ptr), offsets);
        }
    }
}