using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HEAP_SEGMENT_MGR_COMMIT_STATE")]
    public sealed class _HEAP_SEGMENT_MGR_COMMIT_STATE : DynamicStructure
    {
        public ushort CommittedPageCount { get; }
        public ushort Spare { get; }
        public ushort LargePageOperationInProgress { get; }
        public ushort LargePageCommit { get; }
        public ushort EntireUShortV { get; }
        public ushort EntireUShort { get; }

        public _HEAP_SEGMENT_MGR_COMMIT_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_SEGMENT_MGR_COMMIT_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_SEGMENT_MGR_COMMIT_STATE.CommittedPageCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_SEGMENT_MGR_COMMIT_STATE.Spare),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_SEGMENT_MGR_COMMIT_STATE.LargePageOperationInProgress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_SEGMENT_MGR_COMMIT_STATE.LargePageCommit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_SEGMENT_MGR_COMMIT_STATE.EntireUShortV),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_SEGMENT_MGR_COMMIT_STATE.EntireUShort),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_SEGMENT_MGR_COMMIT_STATE>((mem, ptr) => new _HEAP_SEGMENT_MGR_COMMIT_STATE(mem, ptr), offsets);
        }
    }
}