using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VI_DEADLOCK_THREAD")]
    public sealed class _VI_DEADLOCK_THREAD : DynamicStructure
    {
        public IntPtr Thread { get; }
        public IntPtr CurrentSpinNode { get; }
        public IntPtr CurrentOtherNode { get; }
        public _LIST_ENTRY ListEntry { get; }
        public _LIST_ENTRY FreeListEntry { get; }
        public uint NodeCount { get; }
        public uint PagingCount { get; }
        public byte ThreadUsesEresources { get; }

        public _VI_DEADLOCK_THREAD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VI_DEADLOCK_THREAD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VI_DEADLOCK_THREAD.Thread),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_THREAD.CurrentSpinNode),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_THREAD.CurrentOtherNode),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_THREAD.ListEntry),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_THREAD.FreeListEntry),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_THREAD.NodeCount),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_THREAD.PagingCount),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_THREAD.ThreadUsesEresources),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_VI_DEADLOCK_THREAD>((mem, ptr) => new _VI_DEADLOCK_THREAD(mem, ptr), offsets);
        }
    }
}