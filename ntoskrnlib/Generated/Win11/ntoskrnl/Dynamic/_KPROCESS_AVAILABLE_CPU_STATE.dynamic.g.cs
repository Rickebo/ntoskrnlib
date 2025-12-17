using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KPROCESS_AVAILABLE_CPU_STATE")]
    public sealed class _KPROCESS_AVAILABLE_CPU_STATE : DynamicStructure
    {
        public _RTL_TICK_LOCK SequenceNumber { get; }
        public ulong CpuSetSequenceNumber { get; }
        public ulong ForceParkSequenceNumber { get; }
        public IntPtr Affinity { get; }
        public _EX_PUSH_LOCK SubscriptionLock { get; }
        public _LIST_ENTRY SubscriptionList { get; }
        public _KI_AVAILABLE_CPUS_WORK_ITEM WorkItem { get; }

        public _KPROCESS_AVAILABLE_CPU_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KPROCESS_AVAILABLE_CPU_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KPROCESS_AVAILABLE_CPU_STATE.SequenceNumber),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPROCESS_AVAILABLE_CPU_STATE.CpuSetSequenceNumber),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KPROCESS_AVAILABLE_CPU_STATE.ForceParkSequenceNumber),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KPROCESS_AVAILABLE_CPU_STATE.Affinity),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KPROCESS_AVAILABLE_CPU_STATE.SubscriptionLock),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KPROCESS_AVAILABLE_CPU_STATE.SubscriptionList),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KPROCESS_AVAILABLE_CPU_STATE.WorkItem),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_KPROCESS_AVAILABLE_CPU_STATE>((mem, ptr) => new _KPROCESS_AVAILABLE_CPU_STATE(mem, ptr), offsets);
        }
    }
}