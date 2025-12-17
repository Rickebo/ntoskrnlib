using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_LINE_STATE")]
    public sealed class _INTERRUPT_LINE_STATE : DynamicStructure
    {
        public uint Polarity { get; }
        public byte EmulateActiveBoth { get; }
        public uint TriggerMode { get; }
        public uint Flags { get; }
        public _INTERRUPT_LINE Routing { get; }
        public _INTERRUPT_TARGET ProcessorTarget { get; }
        public uint Vector { get; }
        public uint Priority { get; }

        public _INTERRUPT_LINE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INTERRUPT_LINE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INTERRUPT_LINE_STATE.Polarity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINE_STATE.EmulateActiveBoth),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINE_STATE.TriggerMode),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINE_STATE.Flags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINE_STATE.Routing),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINE_STATE.ProcessorTarget),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINE_STATE.Vector),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINE_STATE.Priority),
                    new ulong[]
                    {
                        52UL
                    }
                }
            };
            Register<_INTERRUPT_LINE_STATE>((mem, ptr) => new _INTERRUPT_LINE_STATE(mem, ptr), offsets);
        }
    }
}