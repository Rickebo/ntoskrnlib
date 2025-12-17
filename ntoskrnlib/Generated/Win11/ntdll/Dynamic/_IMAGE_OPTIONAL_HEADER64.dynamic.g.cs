using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_IMAGE_OPTIONAL_HEADER64")]
    public sealed class _IMAGE_OPTIONAL_HEADER64 : DynamicStructure
    {
        public ushort Magic { get; }
        public byte MajorLinkerVersion { get; }
        public byte MinorLinkerVersion { get; }
        public uint SizeOfCode { get; }
        public uint SizeOfInitializedData { get; }
        public uint SizeOfUninitializedData { get; }
        public uint AddressOfEntryPoint { get; }
        public uint BaseOfCode { get; }
        public ulong ImageBase { get; }
        public uint SectionAlignment { get; }
        public uint FileAlignment { get; }
        public ushort MajorOperatingSystemVersion { get; }
        public ushort MinorOperatingSystemVersion { get; }
        public ushort MajorImageVersion { get; }
        public ushort MinorImageVersion { get; }
        public ushort MajorSubsystemVersion { get; }
        public ushort MinorSubsystemVersion { get; }
        public uint Win32VersionValue { get; }
        public uint SizeOfImage { get; }
        public uint SizeOfHeaders { get; }
        public uint CheckSum { get; }
        public ushort Subsystem { get; }
        public ushort DllCharacteristics { get; }
        public ulong SizeOfStackReserve { get; }
        public ulong SizeOfStackCommit { get; }
        public ulong SizeOfHeapReserve { get; }
        public ulong SizeOfHeapCommit { get; }
        public uint LoaderFlags { get; }
        public uint NumberOfRvaAndSizes { get; }
        public byte[] DataDirectory { get; }

        public _IMAGE_OPTIONAL_HEADER64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IMAGE_OPTIONAL_HEADER64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.Magic),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.MajorLinkerVersion),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.MinorLinkerVersion),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.SizeOfCode),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.SizeOfInitializedData),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.SizeOfUninitializedData),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.AddressOfEntryPoint),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.BaseOfCode),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.ImageBase),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.SectionAlignment),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.FileAlignment),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.MajorOperatingSystemVersion),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.MinorOperatingSystemVersion),
                    new ulong[]
                    {
                        42UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.MajorImageVersion),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.MinorImageVersion),
                    new ulong[]
                    {
                        46UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.MajorSubsystemVersion),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.MinorSubsystemVersion),
                    new ulong[]
                    {
                        50UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.Win32VersionValue),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.SizeOfImage),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.SizeOfHeaders),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.CheckSum),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.Subsystem),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.DllCharacteristics),
                    new ulong[]
                    {
                        70UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.SizeOfStackReserve),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.SizeOfStackCommit),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.SizeOfHeapReserve),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.SizeOfHeapCommit),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.LoaderFlags),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.NumberOfRvaAndSizes),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_IMAGE_OPTIONAL_HEADER64.DataDirectory),
                    new ulong[]
                    {
                        112UL
                    }
                }
            };
            Register<_IMAGE_OPTIONAL_HEADER64>((mem, ptr) => new _IMAGE_OPTIONAL_HEADER64(mem, ptr), offsets);
        }
    }
}