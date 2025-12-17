using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PROCESS_EXECUTION_TRANSITION")]
    public sealed class _PROCESS_EXECUTION_TRANSITION : DynamicStructure
    {
        public short TransitionState { get; }
        public ushort InProgress { get; }
        public ushort Reserved { get; }

        public _PROCESS_EXECUTION_TRANSITION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROCESS_EXECUTION_TRANSITION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROCESS_EXECUTION_TRANSITION.TransitionState),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESS_EXECUTION_TRANSITION.InProgress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESS_EXECUTION_TRANSITION.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PROCESS_EXECUTION_TRANSITION>((mem, ptr) => new _PROCESS_EXECUTION_TRANSITION(mem, ptr), offsets);
        }
    }
}