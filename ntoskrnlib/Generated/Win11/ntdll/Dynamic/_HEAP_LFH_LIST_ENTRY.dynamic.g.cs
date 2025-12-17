using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_LFH_LIST_ENTRY")]
    public sealed class _HEAP_LFH_LIST_ENTRY : DynamicStructure
    {
        public ushort Next { get; }
        public ulong Preserve { get; }
        public uint Check { get; }

        public _HEAP_LFH_LIST_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_LIST_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_LIST_ENTRY.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_LIST_ENTRY.Preserve),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_LIST_ENTRY.Check),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_HEAP_LFH_LIST_ENTRY>((mem, ptr) => new _HEAP_LFH_LIST_ENTRY(mem, ptr), offsets);
        }
    }
}