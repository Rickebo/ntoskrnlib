using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMMOD_WRITER_LISTHEAD")]
    public sealed class _MMMOD_WRITER_LISTHEAD : DynamicStructure
    {
        public _LIST_ENTRY ListHead { get; }
        public _KEVENT Event { get; }

        public _MMMOD_WRITER_LISTHEAD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMMOD_WRITER_LISTHEAD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMMOD_WRITER_LISTHEAD.ListHead),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMMOD_WRITER_LISTHEAD.Event),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_MMMOD_WRITER_LISTHEAD>((mem, ptr) => new _MMMOD_WRITER_LISTHEAD(mem, ptr), offsets);
        }
    }
}