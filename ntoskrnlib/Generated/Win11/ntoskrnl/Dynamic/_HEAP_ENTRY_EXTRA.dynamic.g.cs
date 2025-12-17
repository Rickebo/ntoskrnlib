using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_ENTRY_EXTRA")]
    public sealed class _HEAP_ENTRY_EXTRA : DynamicStructure
    {
        public ushort AllocatorBackTraceIndex { get; }
        public ushort TagIndex { get; }
        public ulong Settable { get; }
        public ulong ZeroInit { get; }
        public ulong ZeroInit1 { get; }

        public _HEAP_ENTRY_EXTRA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_ENTRY_EXTRA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_ENTRY_EXTRA.AllocatorBackTraceIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_ENTRY_EXTRA.TagIndex),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_HEAP_ENTRY_EXTRA.Settable),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_ENTRY_EXTRA.ZeroInit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_ENTRY_EXTRA.ZeroInit1),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_HEAP_ENTRY_EXTRA>((mem, ptr) => new _HEAP_ENTRY_EXTRA(mem, ptr), offsets);
        }
    }
}