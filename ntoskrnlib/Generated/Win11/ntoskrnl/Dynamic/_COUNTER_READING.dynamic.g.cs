using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_COUNTER_READING")]
    public sealed class _COUNTER_READING : DynamicStructure
    {
        public uint Type { get; }
        public uint Index { get; }
        public ulong Start { get; }
        public ulong Total { get; }

        public _COUNTER_READING(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _COUNTER_READING()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_COUNTER_READING.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_COUNTER_READING.Index),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_COUNTER_READING.Start),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_COUNTER_READING.Total),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_COUNTER_READING>((mem, ptr) => new _COUNTER_READING(mem, ptr), offsets);
        }
    }
}