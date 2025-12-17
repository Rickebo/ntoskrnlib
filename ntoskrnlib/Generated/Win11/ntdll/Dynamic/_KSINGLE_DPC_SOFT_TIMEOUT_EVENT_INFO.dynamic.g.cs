using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KSINGLE_DPC_SOFT_TIMEOUT_EVENT_INFO")]
    public sealed class _KSINGLE_DPC_SOFT_TIMEOUT_EVENT_INFO : DynamicStructure
    {
        public _KDPC EventDpc { get; }
        public IntPtr DeferredRoutine { get; }
        public uint TickCount { get; }

        public _KSINGLE_DPC_SOFT_TIMEOUT_EVENT_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSINGLE_DPC_SOFT_TIMEOUT_EVENT_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSINGLE_DPC_SOFT_TIMEOUT_EVENT_INFO.EventDpc),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSINGLE_DPC_SOFT_TIMEOUT_EVENT_INFO.DeferredRoutine),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KSINGLE_DPC_SOFT_TIMEOUT_EVENT_INFO.TickCount),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_KSINGLE_DPC_SOFT_TIMEOUT_EVENT_INFO>((mem, ptr) => new _KSINGLE_DPC_SOFT_TIMEOUT_EVENT_INFO(mem, ptr), offsets);
        }
    }
}