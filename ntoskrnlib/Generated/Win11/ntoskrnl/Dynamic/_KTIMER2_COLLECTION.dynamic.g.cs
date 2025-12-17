using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KTIMER2_COLLECTION")]
    public sealed class _KTIMER2_COLLECTION : DynamicStructure
    {
        public _RTL_RB_TREE Tree { get; }
        public ulong NextDueTime { get; }

        public _KTIMER2_COLLECTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KTIMER2_COLLECTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KTIMER2_COLLECTION.Tree),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KTIMER2_COLLECTION.NextDueTime),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_KTIMER2_COLLECTION>((mem, ptr) => new _KTIMER2_COLLECTION(mem, ptr), offsets);
        }
    }
}