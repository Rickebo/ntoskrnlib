using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGK_SILOSTATE")]
    public sealed class _DBGK_SILOSTATE : DynamicStructure
    {
        public _EX_PUSH_LOCK ErrorPortLock { get; }
        public IntPtr ErrorPort { get; }
        public IntPtr ErrorProcess { get; }
        public IntPtr ErrorPortRegisteredEvent { get; }

        public _DBGK_SILOSTATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGK_SILOSTATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGK_SILOSTATE.ErrorPortLock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGK_SILOSTATE.ErrorPort),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DBGK_SILOSTATE.ErrorProcess),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DBGK_SILOSTATE.ErrorPortRegisteredEvent),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_DBGK_SILOSTATE>((mem, ptr) => new _DBGK_SILOSTATE(mem, ptr), offsets);
        }
    }
}