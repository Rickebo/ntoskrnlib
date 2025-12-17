using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_PCI_SLOT_NUMBER")]
    public sealed class _WHEA_PCI_SLOT_NUMBER : DynamicStructure
    {
        public _unnamed_tag_ u { get; }

        public _WHEA_PCI_SLOT_NUMBER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_PCI_SLOT_NUMBER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_PCI_SLOT_NUMBER.u),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WHEA_PCI_SLOT_NUMBER>((mem, ptr) => new _WHEA_PCI_SLOT_NUMBER(mem, ptr), offsets);
        }
    }
}