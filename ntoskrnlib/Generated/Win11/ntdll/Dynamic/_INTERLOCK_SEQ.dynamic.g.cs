using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_INTERLOCK_SEQ")]
    public sealed class _INTERLOCK_SEQ : DynamicStructure
    {
        public ushort Depth { get; }
        public ushort Hint { get; }
        public ushort Lock { get; }
        public ushort Hint16 { get; }
        public int Exchg { get; }

        public _INTERLOCK_SEQ(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INTERLOCK_SEQ()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INTERLOCK_SEQ.Depth),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INTERLOCK_SEQ.Hint),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_INTERLOCK_SEQ.Lock),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_INTERLOCK_SEQ.Hint16),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_INTERLOCK_SEQ.Exchg),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_INTERLOCK_SEQ>((mem, ptr) => new _INTERLOCK_SEQ(mem, ptr), offsets);
        }
    }
}