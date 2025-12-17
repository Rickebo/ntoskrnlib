using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ARBITER_ORDERING_LIST")]
    public sealed class _ARBITER_ORDERING_LIST : DynamicStructure
    {
        public ushort Count { get; }
        public ushort Maximum { get; }
        public IntPtr Orderings { get; }

        public _ARBITER_ORDERING_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARBITER_ORDERING_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARBITER_ORDERING_LIST.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARBITER_ORDERING_LIST.Maximum),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_ARBITER_ORDERING_LIST.Orderings),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_ARBITER_ORDERING_LIST>((mem, ptr) => new _ARBITER_ORDERING_LIST(mem, ptr), offsets);
        }
    }
}