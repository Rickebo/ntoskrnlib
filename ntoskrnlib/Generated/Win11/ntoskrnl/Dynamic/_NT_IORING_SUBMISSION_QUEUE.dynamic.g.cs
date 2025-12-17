using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NT_IORING_SUBMISSION_QUEUE")]
    public sealed class _NT_IORING_SUBMISSION_QUEUE : DynamicStructure
    {
        public uint Head { get; }
        public uint Tail { get; }
        public uint Flags { get; }
        public byte[] Entries { get; }

        public _NT_IORING_SUBMISSION_QUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_IORING_SUBMISSION_QUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_IORING_SUBMISSION_QUEUE.Head),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_IORING_SUBMISSION_QUEUE.Tail),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_NT_IORING_SUBMISSION_QUEUE.Flags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_NT_IORING_SUBMISSION_QUEUE.Entries),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_NT_IORING_SUBMISSION_QUEUE>((mem, ptr) => new _NT_IORING_SUBMISSION_QUEUE(mem, ptr), offsets);
        }
    }
}