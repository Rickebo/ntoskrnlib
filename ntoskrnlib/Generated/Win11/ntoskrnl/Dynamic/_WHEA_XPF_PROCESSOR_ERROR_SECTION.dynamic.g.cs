using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_XPF_PROCESSOR_ERROR_SECTION")]
    public sealed class _WHEA_XPF_PROCESSOR_ERROR_SECTION : DynamicStructure
    {
        public _WHEA_XPF_PROCESSOR_ERROR_SECTION_VALIDBITS ValidBits { get; }
        public ulong LocalAPICId { get; }
        public byte[] CpuId { get; }
        public byte[] VariableInfo { get; }

        public _WHEA_XPF_PROCESSOR_ERROR_SECTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_XPF_PROCESSOR_ERROR_SECTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_XPF_PROCESSOR_ERROR_SECTION.ValidBits),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_XPF_PROCESSOR_ERROR_SECTION.LocalAPICId),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEA_XPF_PROCESSOR_ERROR_SECTION.CpuId),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEA_XPF_PROCESSOR_ERROR_SECTION.VariableInfo),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_WHEA_XPF_PROCESSOR_ERROR_SECTION>((mem, ptr) => new _WHEA_XPF_PROCESSOR_ERROR_SECTION(mem, ptr), offsets);
        }
    }
}