using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_COMPONENT")]
    public sealed class _POP_FX_COMPONENT : DynamicStructure
    {
        public _GUID Id { get; }
        public uint Index { get; }
        public _POP_FX_WORK_ORDER WorkOrder { get; }
        public IntPtr Device { get; }
        public _POP_FX_COMPONENT_FLAGS Flags { get; }
        public int Resident { get; }
        public _KEVENT ActiveEvent { get; }
        public ulong IdleLock { get; }
        public int IdleConditionComplete { get; }
        public int IdleStateComplete { get; }
        public ulong IdleStamp { get; }
        public uint CurrentIdleState { get; }
        public uint IdleStateCount { get; }
        public IntPtr IdleStates { get; }
        public uint DeepestWakeableIdleState { get; }
        public uint ProviderCount { get; }
        public IntPtr Providers { get; }
        public uint IdleProviderCount { get; }
        public uint DependentCount { get; }
        public IntPtr Dependents { get; }
        public _POP_FX_ACCOUNTING Accounting { get; }
        public IntPtr Performance { get; }
        public IntPtr PowerProfile { get; }
        public _LIST_ENTRY ExternalDependents { get; }
        public _LIST_ENTRY ExternalDependencies { get; }

        public _POP_FX_COMPONENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_COMPONENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_COMPONENT.Id),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.Index),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.WorkOrder),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.Device),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.Flags),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.Resident),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.ActiveEvent),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.IdleLock),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.IdleConditionComplete),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.IdleStateComplete),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.IdleStamp),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.CurrentIdleState),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.IdleStateCount),
                    new ulong[]
                    {
                        156UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.IdleStates),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.DeepestWakeableIdleState),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.ProviderCount),
                    new ulong[]
                    {
                        172UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.Providers),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.IdleProviderCount),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.DependentCount),
                    new ulong[]
                    {
                        188UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.Dependents),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.Accounting),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.Performance),
                    new ulong[]
                    {
                        424UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.PowerProfile),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.ExternalDependents),
                    new ulong[]
                    {
                        440UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT.ExternalDependencies),
                    new ulong[]
                    {
                        456UL
                    }
                }
            };
            Register<_POP_FX_COMPONENT>((mem, ptr) => new _POP_FX_COMPONENT(mem, ptr), offsets);
        }
    }
}