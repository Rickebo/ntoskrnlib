using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_HT_INTR_INFO")]
    public sealed class _INTERRUPT_HT_INTR_INFO : DynamicStructure
    {
        public _unnamed_tag_ LowPart { get; }
        public _unnamed_tag_ HighPart { get; }

        public _INTERRUPT_HT_INTR_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INTERRUPT_HT_INTR_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INTERRUPT_HT_INTR_INFO.LowPart),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INTERRUPT_HT_INTR_INFO.HighPart),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_INTERRUPT_HT_INTR_INFO>((mem, ptr) => new _INTERRUPT_HT_INTR_INFO(mem, ptr), offsets);
        }
    }
}