using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS")]
    public sealed class _WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS : DynamicStructure
    {
        public ulong ProcessorType { get; }
        public ulong InstructionSet { get; }
        public ulong ErrorType { get; }
        public ulong Operation { get; }
        public ulong Flags { get; }
        public ulong Level { get; }
        public ulong CPUVersion { get; }
        public ulong CPUBrandString { get; }
        public ulong ProcessorId { get; }
        public ulong TargetAddress { get; }
        public ulong RequesterId { get; }
        public ulong ResponderId { get; }
        public ulong InstructionPointer { get; }
        public ulong NativeModelId { get; }
        public ulong Reserved { get; }
        public ulong ValidBits { get; }

        public _WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS.ProcessorType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS.InstructionSet),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS.ErrorType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS.Operation),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS.Flags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS.Level),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS.CPUVersion),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS.CPUBrandString),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS.ProcessorId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS.TargetAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS.RequesterId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS.ResponderId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS.InstructionPointer),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS.NativeModelId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS.ValidBits),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS>((mem, ptr) => new _WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS(mem, ptr), offsets);
        }
    }
}