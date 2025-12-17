using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IMAGE_DEBUG_DIRECTORY")]
    public sealed class _IMAGE_DEBUG_DIRECTORY : DynamicStructure
    {
        public uint Characteristics { get; }
        public uint TimeDateStamp { get; }
        public ushort MajorVersion { get; }
        public ushort MinorVersion { get; }
        public uint Type { get; }
        public uint SizeOfData { get; }
        public uint AddressOfRawData { get; }
        public uint PointerToRawData { get; }

        public _IMAGE_DEBUG_DIRECTORY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IMAGE_DEBUG_DIRECTORY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IMAGE_DEBUG_DIRECTORY.Characteristics),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IMAGE_DEBUG_DIRECTORY.TimeDateStamp),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IMAGE_DEBUG_DIRECTORY.MajorVersion),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IMAGE_DEBUG_DIRECTORY.MinorVersion),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_IMAGE_DEBUG_DIRECTORY.Type),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_IMAGE_DEBUG_DIRECTORY.SizeOfData),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IMAGE_DEBUG_DIRECTORY.AddressOfRawData),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_IMAGE_DEBUG_DIRECTORY.PointerToRawData),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_IMAGE_DEBUG_DIRECTORY>((mem, ptr) => new _IMAGE_DEBUG_DIRECTORY(mem, ptr), offsets);
        }
    }
}