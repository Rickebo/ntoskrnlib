using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_LINE")]
    public sealed class _INTERRUPT_LINE : DynamicStructure
    {
        public uint UnitId { get; }
        public int Line { get; }

        public _INTERRUPT_LINE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INTERRUPT_LINE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INTERRUPT_LINE.UnitId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINE.Line),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_INTERRUPT_LINE>((mem, ptr) => new _INTERRUPT_LINE(mem, ptr), offsets);
        }
    }
}