using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_XPF_PROCESSOR_ERROR_SECTION_VALIDBITS")]
    public sealed class _WHEA_XPF_PROCESSOR_ERROR_SECTION_VALIDBITS : DynamicStructure
    {
        public ulong LocalAPICId { get; }
        public ulong CpuId { get; }
        public ulong ProcInfoCount { get; }
        public ulong ContextInfoCount { get; }
        public ulong Reserved { get; }
        public ulong ValidBits { get; }

        public _WHEA_XPF_PROCESSOR_ERROR_SECTION_VALIDBITS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_XPF_PROCESSOR_ERROR_SECTION_VALIDBITS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_XPF_PROCESSOR_ERROR_SECTION_VALIDBITS.LocalAPICId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_XPF_PROCESSOR_ERROR_SECTION_VALIDBITS.CpuId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_XPF_PROCESSOR_ERROR_SECTION_VALIDBITS.ProcInfoCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_XPF_PROCESSOR_ERROR_SECTION_VALIDBITS.ContextInfoCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_XPF_PROCESSOR_ERROR_SECTION_VALIDBITS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_XPF_PROCESSOR_ERROR_SECTION_VALIDBITS.ValidBits),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WHEA_XPF_PROCESSOR_ERROR_SECTION_VALIDBITS>((mem, ptr) => new _WHEA_XPF_PROCESSOR_ERROR_SECTION_VALIDBITS(mem, ptr), offsets);
        }
    }
}