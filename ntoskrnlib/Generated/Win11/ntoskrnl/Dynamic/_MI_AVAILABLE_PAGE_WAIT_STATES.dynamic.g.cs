using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_AVAILABLE_PAGE_WAIT_STATES")]
    public sealed class _MI_AVAILABLE_PAGE_WAIT_STATES : DynamicStructure
    {
        public _KEVENT Event { get; }
        public uint EventSets { get; }

        public _MI_AVAILABLE_PAGE_WAIT_STATES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_AVAILABLE_PAGE_WAIT_STATES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_AVAILABLE_PAGE_WAIT_STATES.Event),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_AVAILABLE_PAGE_WAIT_STATES.EventSets),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_MI_AVAILABLE_PAGE_WAIT_STATES>((mem, ptr) => new _MI_AVAILABLE_PAGE_WAIT_STATES(mem, ptr), offsets);
        }
    }
}