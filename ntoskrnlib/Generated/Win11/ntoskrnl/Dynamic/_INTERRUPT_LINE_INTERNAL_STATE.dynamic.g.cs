using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_LINE_INTERNAL_STATE")]
    public sealed class _INTERRUPT_LINE_INTERNAL_STATE : DynamicStructure
    {
        public byte Fixed { get; }
        public byte Irql { get; }
        public byte Swapping { get; }
        public uint OldClusterId { get; }
        public uint OldClusterMask { get; }
        public byte LineStateDetermined { get; }

        public _INTERRUPT_LINE_INTERNAL_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INTERRUPT_LINE_INTERNAL_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INTERRUPT_LINE_INTERNAL_STATE.Fixed),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINE_INTERNAL_STATE.Irql),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINE_INTERNAL_STATE.Swapping),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINE_INTERNAL_STATE.OldClusterId),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINE_INTERNAL_STATE.OldClusterMask),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_INTERRUPT_LINE_INTERNAL_STATE.LineStateDetermined),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_INTERRUPT_LINE_INTERNAL_STATE>((mem, ptr) => new _INTERRUPT_LINE_INTERNAL_STATE(mem, ptr), offsets);
        }
    }
}