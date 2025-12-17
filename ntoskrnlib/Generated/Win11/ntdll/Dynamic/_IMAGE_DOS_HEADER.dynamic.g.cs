using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_IMAGE_DOS_HEADER")]
    public sealed class _IMAGE_DOS_HEADER : DynamicStructure
    {
        public ushort e_magic { get; }
        public ushort e_cblp { get; }
        public ushort e_cp { get; }
        public ushort e_crlc { get; }
        public ushort e_cparhdr { get; }
        public ushort e_minalloc { get; }
        public ushort e_maxalloc { get; }
        public ushort e_ss { get; }
        public ushort e_sp { get; }
        public ushort e_csum { get; }
        public ushort e_ip { get; }
        public ushort e_cs { get; }
        public ushort e_lfarlc { get; }
        public ushort e_ovno { get; }
        public ushort[] e_res { get; }
        public ushort e_oemid { get; }
        public ushort e_oeminfo { get; }
        public ushort[] e_res2 { get; }
        public int e_lfanew { get; }

        public _IMAGE_DOS_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IMAGE_DOS_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IMAGE_DOS_HEADER.e_magic),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IMAGE_DOS_HEADER.e_cblp),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_IMAGE_DOS_HEADER.e_cp),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IMAGE_DOS_HEADER.e_crlc),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_IMAGE_DOS_HEADER.e_cparhdr),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IMAGE_DOS_HEADER.e_minalloc),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_IMAGE_DOS_HEADER.e_maxalloc),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_IMAGE_DOS_HEADER.e_ss),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_IMAGE_DOS_HEADER.e_sp),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IMAGE_DOS_HEADER.e_csum),
                    new ulong[]
                    {
                        18UL
                    }
                },
                {
                    nameof(_IMAGE_DOS_HEADER.e_ip),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_IMAGE_DOS_HEADER.e_cs),
                    new ulong[]
                    {
                        22UL
                    }
                },
                {
                    nameof(_IMAGE_DOS_HEADER.e_lfarlc),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IMAGE_DOS_HEADER.e_ovno),
                    new ulong[]
                    {
                        26UL
                    }
                },
                {
                    nameof(_IMAGE_DOS_HEADER.e_res),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_IMAGE_DOS_HEADER.e_oemid),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_IMAGE_DOS_HEADER.e_oeminfo),
                    new ulong[]
                    {
                        38UL
                    }
                },
                {
                    nameof(_IMAGE_DOS_HEADER.e_res2),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_IMAGE_DOS_HEADER.e_lfanew),
                    new ulong[]
                    {
                        60UL
                    }
                }
            };
            Register<_IMAGE_DOS_HEADER>((mem, ptr) => new _IMAGE_DOS_HEADER(mem, ptr), offsets);
        }
    }
}