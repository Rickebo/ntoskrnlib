using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_EPROCESS_VALUES")]
    public sealed class _EPROCESS_VALUES : DynamicStructure
    {
        public ulong KernelTime { get; }
        public ulong UserTime { get; }
        public ulong ReadyTime { get; }
        public ulong CycleTime { get; }
        public ulong ContextSwitches { get; }
        public long ReadOperationCount { get; }
        public long WriteOperationCount { get; }
        public long OtherOperationCount { get; }
        public long ReadTransferCount { get; }
        public long WriteTransferCount { get; }
        public long OtherTransferCount { get; }
        public ulong KernelWaitTime { get; }
        public ulong UserWaitTime { get; }

        public _EPROCESS_VALUES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EPROCESS_VALUES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EPROCESS_VALUES.KernelTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EPROCESS_VALUES.UserTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EPROCESS_VALUES.ReadyTime),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_EPROCESS_VALUES.CycleTime),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_EPROCESS_VALUES.ContextSwitches),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_EPROCESS_VALUES.ReadOperationCount),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_EPROCESS_VALUES.WriteOperationCount),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_EPROCESS_VALUES.OtherOperationCount),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_EPROCESS_VALUES.ReadTransferCount),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_EPROCESS_VALUES.WriteTransferCount),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_EPROCESS_VALUES.OtherTransferCount),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_EPROCESS_VALUES.KernelWaitTime),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_EPROCESS_VALUES.UserWaitTime),
                    new ulong[]
                    {
                        96UL
                    }
                }
            };
            Register<_EPROCESS_VALUES>((mem, ptr) => new _EPROCESS_VALUES(mem, ptr), offsets);
        }
    }
}