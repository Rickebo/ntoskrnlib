using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IORING_OBJECT")]
    public sealed class _IORING_OBJECT : DynamicStructure
    {
        public short Type { get; }
        public short Size { get; }
        public _NT_IORING_INFO UserInfo { get; }
        public IntPtr Section { get; }
        public IntPtr SubmissionQueue { get; }
        public IntPtr CompletionQueueMdl { get; }
        public IntPtr CompletionQueue { get; }
        public ulong ViewSize { get; }
        public int InSubmit { get; }
        public ulong CompletionLock { get; }
        public ulong SubmitCount { get; }
        public ulong CompletionCount { get; }
        public ulong CompletionWaitUntil { get; }
        public _KEVENT CompletionEvent { get; }
        public byte SignalCompletionEvent { get; }
        public IntPtr CompletionUserEvent { get; }
        public uint RegBuffersCount { get; }
        public IntPtr RegBuffers { get; }
        public uint RegFilesCount { get; }
        public IntPtr RegFiles { get; }

        public _IORING_OBJECT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IORING_OBJECT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IORING_OBJECT.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IORING_OBJECT.Size),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_IORING_OBJECT.UserInfo),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IORING_OBJECT.Section),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_IORING_OBJECT.SubmissionQueue),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_IORING_OBJECT.CompletionQueueMdl),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_IORING_OBJECT.CompletionQueue),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_IORING_OBJECT.ViewSize),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_IORING_OBJECT.InSubmit),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_IORING_OBJECT.CompletionLock),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_IORING_OBJECT.SubmitCount),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_IORING_OBJECT.CompletionCount),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_IORING_OBJECT.CompletionWaitUntil),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_IORING_OBJECT.CompletionEvent),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_IORING_OBJECT.SignalCompletionEvent),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_IORING_OBJECT.CompletionUserEvent),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_IORING_OBJECT.RegBuffersCount),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_IORING_OBJECT.RegBuffers),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_IORING_OBJECT.RegFilesCount),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_IORING_OBJECT.RegFiles),
                    new ulong[]
                    {
                        200UL
                    }
                }
            };
            Register<_IORING_OBJECT>((mem, ptr) => new _IORING_OBJECT(mem, ptr), offsets);
        }
    }
}