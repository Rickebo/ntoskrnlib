using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_ACCESS_LOG_STATE")]
    public sealed class _MI_ACCESS_LOG_STATE : DynamicStructure
    {
        public IntPtr CcAccessLog { get; }
        public _WORK_QUEUE_ITEM DisableAccessLoggingWorkItem { get; }
        public uint DisableAccessLoggingState { get; }
        public uint Enabled { get; }
        public uint MinLoggingPriority { get; }
        public IntPtr PfnRepurposeLog { get; }
        public _KDPC AllocatePfnRepurposeDpc { get; }
        public int AccessLoggingLock { get; }

        public _MI_ACCESS_LOG_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_ACCESS_LOG_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_ACCESS_LOG_STATE.CcAccessLog),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_ACCESS_LOG_STATE.DisableAccessLoggingWorkItem),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_ACCESS_LOG_STATE.DisableAccessLoggingState),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_ACCESS_LOG_STATE.Enabled),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_MI_ACCESS_LOG_STATE.MinLoggingPriority),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MI_ACCESS_LOG_STATE.PfnRepurposeLog),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MI_ACCESS_LOG_STATE.AllocatePfnRepurposeDpc),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MI_ACCESS_LOG_STATE.AccessLoggingLock),
                    new ulong[]
                    {
                        128UL
                    }
                }
            };
            Register<_MI_ACCESS_LOG_STATE>((mem, ptr) => new _MI_ACCESS_LOG_STATE(mem, ptr), offsets);
        }
    }
}