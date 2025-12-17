using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ARBITER_ALLOCATION_STATE")]
    public sealed class _ARBITER_ALLOCATION_STATE : DynamicStructure
    {
        public ulong Start { get; }
        public ulong End { get; }
        public ulong CurrentMinimum { get; }
        public ulong CurrentMaximum { get; }
        public IntPtr Entry { get; }
        public IntPtr CurrentAlternative { get; }
        public uint AlternativeCount { get; }
        public IntPtr Alternatives { get; }
        public ushort Flags { get; }
        public byte RangeAttributes { get; }
        public byte RangeAvailableAttributes { get; }
        public ulong WorkSpace { get; }

        public _ARBITER_ALLOCATION_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARBITER_ALLOCATION_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARBITER_ALLOCATION_STATE.Start),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARBITER_ALLOCATION_STATE.End),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ARBITER_ALLOCATION_STATE.CurrentMinimum),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ARBITER_ALLOCATION_STATE.CurrentMaximum),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_ARBITER_ALLOCATION_STATE.Entry),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ARBITER_ALLOCATION_STATE.CurrentAlternative),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_ARBITER_ALLOCATION_STATE.AlternativeCount),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_ARBITER_ALLOCATION_STATE.Alternatives),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_ARBITER_ALLOCATION_STATE.Flags),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_ARBITER_ALLOCATION_STATE.RangeAttributes),
                    new ulong[]
                    {
                        66UL
                    }
                },
                {
                    nameof(_ARBITER_ALLOCATION_STATE.RangeAvailableAttributes),
                    new ulong[]
                    {
                        67UL
                    }
                },
                {
                    nameof(_ARBITER_ALLOCATION_STATE.WorkSpace),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_ARBITER_ALLOCATION_STATE>((mem, ptr) => new _ARBITER_ALLOCATION_STATE(mem, ptr), offsets);
        }
    }
}