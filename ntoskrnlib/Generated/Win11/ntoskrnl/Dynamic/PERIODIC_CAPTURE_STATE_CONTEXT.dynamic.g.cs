using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!PERIODIC_CAPTURE_STATE_CONTEXT")]
    public sealed class PERIODIC_CAPTURE_STATE_CONTEXT : DynamicStructure
    {
        public long RelativeTimerDueTime { get; }
        public IntPtr Timer { get; }
        public _PERIODIC_CAPTURE_STATE_GUIDS Guids { get; }
        public _WORK_QUEUE_ITEM WorkItem { get; }
        public uint TimerState { get; }

        public PERIODIC_CAPTURE_STATE_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static PERIODIC_CAPTURE_STATE_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(PERIODIC_CAPTURE_STATE_CONTEXT.RelativeTimerDueTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(PERIODIC_CAPTURE_STATE_CONTEXT.Timer),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(PERIODIC_CAPTURE_STATE_CONTEXT.Guids),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(PERIODIC_CAPTURE_STATE_CONTEXT.WorkItem),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(PERIODIC_CAPTURE_STATE_CONTEXT.TimerState),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<PERIODIC_CAPTURE_STATE_CONTEXT>((mem, ptr) => new PERIODIC_CAPTURE_STATE_CONTEXT(mem, ptr), offsets);
        }
    }
}