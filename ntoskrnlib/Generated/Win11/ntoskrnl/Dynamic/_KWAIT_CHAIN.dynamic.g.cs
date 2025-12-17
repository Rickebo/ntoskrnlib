using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KWAIT_CHAIN")]
    public sealed class _KWAIT_CHAIN : DynamicStructure
    {
        public IntPtr Head { get; }

        public _KWAIT_CHAIN(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KWAIT_CHAIN()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KWAIT_CHAIN.Head),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KWAIT_CHAIN>((mem, ptr) => new _KWAIT_CHAIN(mem, ptr), offsets);
        }
    }
}