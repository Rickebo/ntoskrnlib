using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PROCESS_EXECUTION")]
    public sealed class _PROCESS_EXECUTION : DynamicStructure
    {
        public int State { get; }
        public _PROCESS_EXECUTION_TRANSITION Transition { get; }
        public _PROCESS_EXECUTION_STATE Current { get; }
        public _PROCESS_EXECUTION_STATE Requested { get; }

        public _PROCESS_EXECUTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROCESS_EXECUTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROCESS_EXECUTION.State),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESS_EXECUTION.Transition),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESS_EXECUTION.Current),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_PROCESS_EXECUTION.Requested),
                    new ulong[]
                    {
                        3UL
                    }
                }
            };
            Register<_PROCESS_EXECUTION>((mem, ptr) => new _PROCESS_EXECUTION(mem, ptr), offsets);
        }
    }
}