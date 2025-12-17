using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_TICK_LOCK")]
    public sealed class _RTL_TICK_LOCK : DynamicStructure
    {
        public ulong AsULong64 { get; }
        public ulong Busy { get; }
        public ulong Ticks { get; }

        public _RTL_TICK_LOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_TICK_LOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_TICK_LOCK.AsULong64),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_TICK_LOCK.Busy),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_TICK_LOCK.Ticks),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_RTL_TICK_LOCK>((mem, ptr) => new _RTL_TICK_LOCK(mem, ptr), offsets);
        }
    }
}