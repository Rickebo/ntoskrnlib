using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SECONDARY_INTERRUPT_LINE_STATE")]
    public sealed class _SECONDARY_INTERRUPT_LINE_STATE : DynamicStructure
    {
        public uint Polarity { get; }
        public uint Mode { get; }
        public uint Vector { get; }
        public byte Unmasked { get; }

        public _SECONDARY_INTERRUPT_LINE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SECONDARY_INTERRUPT_LINE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SECONDARY_INTERRUPT_LINE_STATE.Polarity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SECONDARY_INTERRUPT_LINE_STATE.Mode),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_SECONDARY_INTERRUPT_LINE_STATE.Vector),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SECONDARY_INTERRUPT_LINE_STATE.Unmasked),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_SECONDARY_INTERRUPT_LINE_STATE>((mem, ptr) => new _SECONDARY_INTERRUPT_LINE_STATE(mem, ptr), offsets);
        }
    }
}