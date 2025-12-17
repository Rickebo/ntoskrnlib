using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KSTACK_COUNT")]
    public sealed class _KSTACK_COUNT : DynamicStructure
    {
        public int Value { get; }
        public uint State { get; }
        public uint StackCount { get; }

        public _KSTACK_COUNT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSTACK_COUNT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSTACK_COUNT.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSTACK_COUNT.State),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSTACK_COUNT.StackCount),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KSTACK_COUNT>((mem, ptr) => new _KSTACK_COUNT(mem, ptr), offsets);
        }
    }
}