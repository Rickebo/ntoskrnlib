using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_CONDITION_VARIABLE")]
    public sealed class _RTL_CONDITION_VARIABLE : DynamicStructure
    {
        public ulong WakeCount { get; }
        public ulong Waking { get; }
        public ulong Value { get; }
        public IntPtr Ptr { get; }

        public _RTL_CONDITION_VARIABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_CONDITION_VARIABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_CONDITION_VARIABLE.WakeCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_CONDITION_VARIABLE.Waking),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_CONDITION_VARIABLE.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_CONDITION_VARIABLE.Ptr),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_RTL_CONDITION_VARIABLE>((mem, ptr) => new _RTL_CONDITION_VARIABLE(mem, ptr), offsets);
        }
    }
}