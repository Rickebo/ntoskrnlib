using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMDEREFERENCE_SEGMENT_HEADER")]
    public sealed class _MMDEREFERENCE_SEGMENT_HEADER : DynamicStructure
    {
        public _KEVENT Event { get; }
        public _LIST_ENTRY ControlAreaDeleteListHead { get; }
        public _LIST_ENTRY UnusedSegmentDeleteListHead { get; }
        public _LIST_ENTRY PagefileExtensionListHead { get; }

        public _MMDEREFERENCE_SEGMENT_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMDEREFERENCE_SEGMENT_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMDEREFERENCE_SEGMENT_HEADER.Event),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMDEREFERENCE_SEGMENT_HEADER.ControlAreaDeleteListHead),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MMDEREFERENCE_SEGMENT_HEADER.UnusedSegmentDeleteListHead),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MMDEREFERENCE_SEGMENT_HEADER.PagefileExtensionListHead),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_MMDEREFERENCE_SEGMENT_HEADER>((mem, ptr) => new _MMDEREFERENCE_SEGMENT_HEADER(mem, ptr), offsets);
        }
    }
}