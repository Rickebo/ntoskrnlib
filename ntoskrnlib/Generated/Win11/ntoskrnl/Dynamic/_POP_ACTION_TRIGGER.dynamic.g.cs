using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_ACTION_TRIGGER")]
    public sealed class _POP_ACTION_TRIGGER : DynamicStructure
    {
        public uint Type { get; }
        public uint Flags { get; }
        public IntPtr Wait { get; }
        public IntPtr DiagnosticContext { get; }
        public _unnamed_tag_ Battery { get; }
        public _unnamed_tag_ Button { get; }

        public _POP_ACTION_TRIGGER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_ACTION_TRIGGER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_ACTION_TRIGGER.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_ACTION_TRIGGER.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_POP_ACTION_TRIGGER.Wait),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_ACTION_TRIGGER.DiagnosticContext),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_ACTION_TRIGGER.Battery),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_ACTION_TRIGGER.Button),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_POP_ACTION_TRIGGER>((mem, ptr) => new _POP_ACTION_TRIGGER(mem, ptr), offsets);
        }
    }
}