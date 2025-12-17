using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PAGE_MOVE_PROGRESS_STATE")]
    public sealed class _MI_PAGE_MOVE_PROGRESS_STATE : DynamicStructure
    {
        public ulong InProgressProcessors { get; }
        public ulong SequenceNumber { get; }
        public long EntireValue { get; }

        public _MI_PAGE_MOVE_PROGRESS_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PAGE_MOVE_PROGRESS_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PAGE_MOVE_PROGRESS_STATE.InProgressProcessors),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PAGE_MOVE_PROGRESS_STATE.SequenceNumber),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PAGE_MOVE_PROGRESS_STATE.EntireValue),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_PAGE_MOVE_PROGRESS_STATE>((mem, ptr) => new _MI_PAGE_MOVE_PROGRESS_STATE(mem, ptr), offsets);
        }
    }
}