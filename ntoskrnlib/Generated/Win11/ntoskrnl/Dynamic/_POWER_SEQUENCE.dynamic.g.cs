using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POWER_SEQUENCE")]
    public sealed class _POWER_SEQUENCE : DynamicStructure
    {
        public uint SequenceD1 { get; }
        public uint SequenceD2 { get; }
        public uint SequenceD3 { get; }

        public _POWER_SEQUENCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POWER_SEQUENCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POWER_SEQUENCE.SequenceD1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POWER_SEQUENCE.SequenceD2),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_POWER_SEQUENCE.SequenceD3),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_POWER_SEQUENCE>((mem, ptr) => new _POWER_SEQUENCE(mem, ptr), offsets);
        }
    }
}