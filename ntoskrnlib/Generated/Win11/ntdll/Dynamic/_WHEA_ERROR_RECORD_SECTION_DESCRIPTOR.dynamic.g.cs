using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR")]
    public sealed class _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR : DynamicStructure
    {
        public uint SectionOffset { get; }
        public uint SectionLength { get; }
        public _WHEA_REVISION Revision { get; }
        public _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_VALIDBITS ValidBits { get; }
        public byte Reserved { get; }
        public _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS Flags { get; }
        public _GUID SectionType { get; }
        public _GUID FRUId { get; }
        public uint SectionSeverity { get; }
        public sbyte[] FRUText { get; }

        public _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR.SectionOffset),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR.SectionLength),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR.Revision),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR.ValidBits),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR.Reserved),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR.Flags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR.SectionType),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR.FRUId),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR.SectionSeverity),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR.FRUText),
                    new ulong[]
                    {
                        52UL
                    }
                }
            };
            Register<_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR>((mem, ptr) => new _WHEA_ERROR_RECORD_SECTION_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}