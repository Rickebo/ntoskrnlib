using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NT_IORING_INFO")]
    public sealed class _NT_IORING_INFO : DynamicStructure
    {
        public uint IoRingVersion { get; }
        public _NT_IORING_CREATE_FLAGS Flags { get; }
        public uint SubmissionQueueSize { get; }
        public uint SubmissionQueueRingMask { get; }
        public uint CompletionQueueSize { get; }
        public uint CompletionQueueRingMask { get; }
        public IntPtr SubmissionQueue { get; }
        public IntPtr CompletionQueue { get; }

        public _NT_IORING_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_IORING_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_IORING_INFO.IoRingVersion),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_IORING_INFO.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_NT_IORING_INFO.SubmissionQueueSize),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_NT_IORING_INFO.SubmissionQueueRingMask),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NT_IORING_INFO.CompletionQueueSize),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_NT_IORING_INFO.CompletionQueueRingMask),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_NT_IORING_INFO.SubmissionQueue),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_NT_IORING_INFO.CompletionQueue),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_NT_IORING_INFO>((mem, ptr) => new _NT_IORING_INFO(mem, ptr), offsets);
        }
    }
}