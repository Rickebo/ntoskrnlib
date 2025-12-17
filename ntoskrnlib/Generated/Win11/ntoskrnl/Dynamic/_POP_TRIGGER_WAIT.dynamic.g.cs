using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_TRIGGER_WAIT")]
    public sealed class _POP_TRIGGER_WAIT : DynamicStructure
    {
        public _KEVENT Event { get; }
        public int Status { get; }
        public _LIST_ENTRY Link { get; }
        public IntPtr Trigger { get; }

        public _POP_TRIGGER_WAIT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_TRIGGER_WAIT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_TRIGGER_WAIT.Event),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_TRIGGER_WAIT.Status),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_TRIGGER_WAIT.Link),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_TRIGGER_WAIT.Trigger),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_POP_TRIGGER_WAIT>((mem, ptr) => new _POP_TRIGGER_WAIT(mem, ptr), offsets);
        }
    }
}