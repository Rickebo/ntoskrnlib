using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_REMAPPING_INFO")]
    public sealed class _INTERRUPT_REMAPPING_INFO : DynamicStructure
    {
        public uint IrtIndex { get; }
        public uint FlagHalInternal { get; }
        public uint FlagTranslated { get; }
        public _unnamed_tag_ u { get; }

        public _INTERRUPT_REMAPPING_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INTERRUPT_REMAPPING_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INTERRUPT_REMAPPING_INFO.IrtIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INTERRUPT_REMAPPING_INFO.FlagHalInternal),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INTERRUPT_REMAPPING_INFO.FlagTranslated),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INTERRUPT_REMAPPING_INFO.u),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_INTERRUPT_REMAPPING_INFO>((mem, ptr) => new _INTERRUPT_REMAPPING_INFO(mem, ptr), offsets);
        }
    }
}