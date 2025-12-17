using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NT_IORING_COMPLETION_QUEUE")]
    public sealed class _NT_IORING_COMPLETION_QUEUE : DynamicStructure
    {
        public uint Head { get; }
        public uint Tail { get; }
        public byte[] Entries { get; }

        public _NT_IORING_COMPLETION_QUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_IORING_COMPLETION_QUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_IORING_COMPLETION_QUEUE.Head),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_IORING_COMPLETION_QUEUE.Tail),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_NT_IORING_COMPLETION_QUEUE.Entries),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_NT_IORING_COMPLETION_QUEUE>((mem, ptr) => new _NT_IORING_COMPLETION_QUEUE(mem, ptr), offsets);
        }
    }
}