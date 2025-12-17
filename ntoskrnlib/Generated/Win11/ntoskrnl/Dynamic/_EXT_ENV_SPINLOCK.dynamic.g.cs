using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXT_ENV_SPINLOCK")]
    public sealed class _EXT_ENV_SPINLOCK : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public ulong Lock { get; }
        public byte OldIrql { get; }

        public _EXT_ENV_SPINLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXT_ENV_SPINLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXT_ENV_SPINLOCK.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXT_ENV_SPINLOCK.Lock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_EXT_ENV_SPINLOCK.OldIrql),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_EXT_ENV_SPINLOCK>((mem, ptr) => new _EXT_ENV_SPINLOCK(mem, ptr), offsets);
        }
    }
}