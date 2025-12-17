using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_LIST_ENTRY")]
    public sealed class _LIST_ENTRY : DynamicStructure
    {
        public IntPtr Flink { get; }
        public IntPtr Blink { get; }

        public _LIST_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LIST_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LIST_ENTRY.Flink),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LIST_ENTRY.Blink),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_LIST_ENTRY>((mem, ptr) => new _LIST_ENTRY(mem, ptr), offsets);
        }
    }
}