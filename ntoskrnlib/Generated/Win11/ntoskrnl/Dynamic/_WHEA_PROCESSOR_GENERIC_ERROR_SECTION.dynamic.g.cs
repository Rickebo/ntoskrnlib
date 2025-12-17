using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_PROCESSOR_GENERIC_ERROR_SECTION")]
    public sealed class _WHEA_PROCESSOR_GENERIC_ERROR_SECTION : DynamicStructure
    {
        public _WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS ValidBits { get; }
        public byte ProcessorType { get; }
        public byte InstructionSet { get; }
        public byte ErrorType { get; }
        public byte Operation { get; }
        public byte Flags { get; }
        public byte Level { get; }
        public ushort Reserved { get; }
        public ulong CPUVersion { get; }
        public byte[] CPUBrandString { get; }
        public ulong ProcessorId { get; }
        public ulong TargetAddress { get; }
        public ulong RequesterId { get; }
        public ulong ResponderId { get; }
        public ulong InstructionPointer { get; }

        public _WHEA_PROCESSOR_GENERIC_ERROR_SECTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_PROCESSOR_GENERIC_ERROR_SECTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION.ValidBits),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION.ProcessorType),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION.InstructionSet),
                    new ulong[]
                    {
                        9UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION.ErrorType),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION.Operation),
                    new ulong[]
                    {
                        11UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION.Flags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION.Level),
                    new ulong[]
                    {
                        13UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION.Reserved),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION.CPUVersion),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION.CPUBrandString),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION.ProcessorId),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION.TargetAddress),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION.RequesterId),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION.ResponderId),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION.InstructionPointer),
                    new ulong[]
                    {
                        184UL
                    }
                }
            };
            Register<_WHEA_PROCESSOR_GENERIC_ERROR_SECTION>((mem, ptr) => new _WHEA_PROCESSOR_GENERIC_ERROR_SECTION(mem, ptr), offsets);
        }
    }
}