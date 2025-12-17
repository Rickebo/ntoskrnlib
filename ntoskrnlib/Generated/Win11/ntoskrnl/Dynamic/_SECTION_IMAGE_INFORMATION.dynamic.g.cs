using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SECTION_IMAGE_INFORMATION")]
    public sealed class _SECTION_IMAGE_INFORMATION : DynamicStructure
    {
        public IntPtr TransferAddress { get; }
        public uint ZeroBits { get; }
        public ulong MaximumStackSize { get; }
        public ulong CommittedStackSize { get; }
        public uint SubSystemType { get; }
        public ushort SubSystemMinorVersion { get; }
        public ushort SubSystemMajorVersion { get; }
        public uint SubSystemVersion { get; }
        public ushort MajorOperatingSystemVersion { get; }
        public ushort MinorOperatingSystemVersion { get; }
        public uint OperatingSystemVersion { get; }
        public ushort ImageCharacteristics { get; }
        public ushort DllCharacteristics { get; }
        public ushort Machine { get; }
        public byte ImageContainsCode { get; }
        public byte ImageFlags { get; }
        public byte ComPlusNativeReady { get; }
        public byte ComPlusILOnly { get; }
        public byte ImageDynamicallyRelocated { get; }
        public byte ImageMappedFlat { get; }
        public byte BaseBelow4gb { get; }
        public byte ComPlusPrefer32bit { get; }
        public byte Reserved { get; }
        public uint LoaderFlags { get; }
        public uint ImageFileSize { get; }
        public uint CheckSum { get; }

        public _SECTION_IMAGE_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SECTION_IMAGE_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SECTION_IMAGE_INFORMATION.TransferAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.ZeroBits),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.MaximumStackSize),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.CommittedStackSize),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.SubSystemType),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.SubSystemMinorVersion),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.SubSystemMajorVersion),
                    new ulong[]
                    {
                        38UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.SubSystemVersion),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.MajorOperatingSystemVersion),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.MinorOperatingSystemVersion),
                    new ulong[]
                    {
                        42UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.OperatingSystemVersion),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.ImageCharacteristics),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.DllCharacteristics),
                    new ulong[]
                    {
                        46UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.Machine),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.ImageContainsCode),
                    new ulong[]
                    {
                        50UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.ImageFlags),
                    new ulong[]
                    {
                        51UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.ComPlusNativeReady),
                    new ulong[]
                    {
                        51UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.ComPlusILOnly),
                    new ulong[]
                    {
                        51UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.ImageDynamicallyRelocated),
                    new ulong[]
                    {
                        51UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.ImageMappedFlat),
                    new ulong[]
                    {
                        51UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.BaseBelow4gb),
                    new ulong[]
                    {
                        51UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.ComPlusPrefer32bit),
                    new ulong[]
                    {
                        51UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.Reserved),
                    new ulong[]
                    {
                        51UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.LoaderFlags),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.ImageFileSize),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_SECTION_IMAGE_INFORMATION.CheckSum),
                    new ulong[]
                    {
                        60UL
                    }
                }
            };
            Register<_SECTION_IMAGE_INFORMATION>((mem, ptr) => new _SECTION_IMAGE_INFORMATION(mem, ptr), offsets);
        }
    }
}