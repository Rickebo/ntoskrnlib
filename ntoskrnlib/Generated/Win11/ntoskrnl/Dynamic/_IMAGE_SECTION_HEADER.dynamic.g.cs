using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IMAGE_SECTION_HEADER")]
    public sealed class _IMAGE_SECTION_HEADER : DynamicStructure
    {
        public byte[] Name { get; }
        public _unnamed_tag_ Misc { get; }
        public uint VirtualAddress { get; }
        public uint SizeOfRawData { get; }
        public uint PointerToRawData { get; }
        public uint PointerToRelocations { get; }
        public uint PointerToLinenumbers { get; }
        public ushort NumberOfRelocations { get; }
        public ushort NumberOfLinenumbers { get; }
        public uint Characteristics { get; }

        public _IMAGE_SECTION_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IMAGE_SECTION_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IMAGE_SECTION_HEADER.Name),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IMAGE_SECTION_HEADER.Misc),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IMAGE_SECTION_HEADER.VirtualAddress),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_IMAGE_SECTION_HEADER.SizeOfRawData),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IMAGE_SECTION_HEADER.PointerToRawData),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_IMAGE_SECTION_HEADER.PointerToRelocations),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IMAGE_SECTION_HEADER.PointerToLinenumbers),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_IMAGE_SECTION_HEADER.NumberOfRelocations),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_IMAGE_SECTION_HEADER.NumberOfLinenumbers),
                    new ulong[]
                    {
                        34UL
                    }
                },
                {
                    nameof(_IMAGE_SECTION_HEADER.Characteristics),
                    new ulong[]
                    {
                        36UL
                    }
                }
            };
            Register<_IMAGE_SECTION_HEADER>((mem, ptr) => new _IMAGE_SECTION_HEADER(mem, ptr), offsets);
        }
    }
}