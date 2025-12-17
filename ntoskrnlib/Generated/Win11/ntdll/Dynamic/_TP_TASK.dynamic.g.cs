using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TP_TASK")]
    public sealed class _TP_TASK : DynamicStructure
    {
        public IntPtr Callbacks { get; }
        public uint NumaNode { get; }
        public byte IdealProcessor { get; }
        public _LIST_ENTRY ListEntry { get; }

        public _TP_TASK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TP_TASK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TP_TASK.Callbacks),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TP_TASK.NumaNode),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_TP_TASK.IdealProcessor),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_TP_TASK.ListEntry),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_TP_TASK>((mem, ptr) => new _TP_TASK(mem, ptr), offsets);
        }
    }
}