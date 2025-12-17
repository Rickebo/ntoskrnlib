using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TRIAGE_9F_DIRECTED_TRANSITION")]
    public sealed class _TRIAGE_9F_DIRECTED_TRANSITION : DynamicStructure
    {
        public ushort Signature { get; }
        public ushort Revision { get; }
        public IntPtr IrpList { get; }
        public IntPtr ThreadList { get; }
        public IntPtr DelayedWorkQueue { get; }
        public IntPtr DelayedIoWorkQueue { get; }
        public uint WatchdogTimeout { get; }
        public ulong WatchdogStartTimestamp { get; }
        public IntPtr WatchdogStartThread { get; }
        public uint DirectedTransitionStatus { get; }
        public uint DirectedTransitionCallCount { get; }

        public _TRIAGE_9F_DIRECTED_TRANSITION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TRIAGE_9F_DIRECTED_TRANSITION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TRIAGE_9F_DIRECTED_TRANSITION.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_DIRECTED_TRANSITION.Revision),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_DIRECTED_TRANSITION.IrpList),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_DIRECTED_TRANSITION.ThreadList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_DIRECTED_TRANSITION.DelayedWorkQueue),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_DIRECTED_TRANSITION.DelayedIoWorkQueue),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_DIRECTED_TRANSITION.WatchdogTimeout),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_DIRECTED_TRANSITION.WatchdogStartTimestamp),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_DIRECTED_TRANSITION.WatchdogStartThread),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_DIRECTED_TRANSITION.DirectedTransitionStatus),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_TRIAGE_9F_DIRECTED_TRANSITION.DirectedTransitionCallCount),
                    new ulong[]
                    {
                        68UL
                    }
                }
            };
            Register<_TRIAGE_9F_DIRECTED_TRANSITION>((mem, ptr) => new _TRIAGE_9F_DIRECTED_TRANSITION(mem, ptr), offsets);
        }
    }
}