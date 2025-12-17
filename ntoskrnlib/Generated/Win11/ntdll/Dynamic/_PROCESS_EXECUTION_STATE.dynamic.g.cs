using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_PROCESS_EXECUTION_STATE")]
    public sealed class _PROCESS_EXECUTION_STATE : DynamicStructure
    {
        public sbyte State { get; }
        public byte ProcessFrozen { get; }
        public byte ProcessSwapped { get; }
        public byte ProcessGraphicsFreezeOptimized { get; }
        public byte Reserved { get; }

        public _PROCESS_EXECUTION_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROCESS_EXECUTION_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROCESS_EXECUTION_STATE.State),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESS_EXECUTION_STATE.ProcessFrozen),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESS_EXECUTION_STATE.ProcessSwapped),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESS_EXECUTION_STATE.ProcessGraphicsFreezeOptimized),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESS_EXECUTION_STATE.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PROCESS_EXECUTION_STATE>((mem, ptr) => new _PROCESS_EXECUTION_STATE(mem, ptr), offsets);
        }
    }
}