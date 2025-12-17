using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IMAGE_ROM_OPTIONAL_HEADER")]
    public sealed class _IMAGE_ROM_OPTIONAL_HEADER : DynamicStructure
    {
        public ushort Magic { get; }
        public byte MajorLinkerVersion { get; }
        public byte MinorLinkerVersion { get; }
        public uint SizeOfCode { get; }
        public uint SizeOfInitializedData { get; }
        public uint SizeOfUninitializedData { get; }
        public uint AddressOfEntryPoint { get; }
        public uint BaseOfCode { get; }
        public uint BaseOfData { get; }
        public uint BaseOfBss { get; }
        public uint GprMask { get; }
        public uint[] CprMask { get; }
        public uint GpValue { get; }

        public _IMAGE_ROM_OPTIONAL_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IMAGE_ROM_OPTIONAL_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IMAGE_ROM_OPTIONAL_HEADER.Magic),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IMAGE_ROM_OPTIONAL_HEADER.MajorLinkerVersion),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_IMAGE_ROM_OPTIONAL_HEADER.MinorLinkerVersion),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_IMAGE_ROM_OPTIONAL_HEADER.SizeOfCode),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IMAGE_ROM_OPTIONAL_HEADER.SizeOfInitializedData),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IMAGE_ROM_OPTIONAL_HEADER.SizeOfUninitializedData),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_IMAGE_ROM_OPTIONAL_HEADER.AddressOfEntryPoint),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IMAGE_ROM_OPTIONAL_HEADER.BaseOfCode),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_IMAGE_ROM_OPTIONAL_HEADER.BaseOfData),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IMAGE_ROM_OPTIONAL_HEADER.BaseOfBss),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_IMAGE_ROM_OPTIONAL_HEADER.GprMask),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_IMAGE_ROM_OPTIONAL_HEADER.CprMask),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_IMAGE_ROM_OPTIONAL_HEADER.GpValue),
                    new ulong[]
                    {
                        52UL
                    }
                }
            };
            Register<_IMAGE_ROM_OPTIONAL_HEADER>((mem, ptr) => new _IMAGE_ROM_OPTIONAL_HEADER(mem, ptr), offsets);
        }
    }
}