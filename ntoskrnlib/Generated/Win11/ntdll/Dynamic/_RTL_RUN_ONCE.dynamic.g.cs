using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_RUN_ONCE")]
    public sealed class _RTL_RUN_ONCE : DynamicStructure
    {
        public IntPtr Ptr { get; }
        public ulong Value { get; }
        public ulong State { get; }

        public _RTL_RUN_ONCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_RUN_ONCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_RUN_ONCE.Ptr),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_RUN_ONCE.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_RUN_ONCE.State),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_RTL_RUN_ONCE>((mem, ptr) => new _RTL_RUN_ONCE(mem, ptr), offsets);
        }
    }
}