using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VI_DEADLOCK_RESOURCE")]
    public sealed class _VI_DEADLOCK_RESOURCE : DynamicStructure
    {
        public uint Type { get; }
        public uint NodeCount { get; }
        public uint RecursionCount { get; }
        public IntPtr ResourceAddress { get; }
        public IntPtr ThreadOwner { get; }
        public _LIST_ENTRY ResourceList { get; }
        public _LIST_ENTRY HashChainList { get; }
        public _LIST_ENTRY FreeListEntry { get; }
        public byte[] StackTrace { get; }
        public byte[] LastAcquireTrace { get; }
        public byte[] LastReleaseTrace { get; }

        public _VI_DEADLOCK_RESOURCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VI_DEADLOCK_RESOURCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VI_DEADLOCK_RESOURCE.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_RESOURCE.NodeCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_RESOURCE.RecursionCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_RESOURCE.ResourceAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_RESOURCE.ThreadOwner),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_RESOURCE.ResourceList),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_RESOURCE.HashChainList),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_RESOURCE.FreeListEntry),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_RESOURCE.StackTrace),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_RESOURCE.LastAcquireTrace),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_RESOURCE.LastReleaseTrace),
                    new ulong[]
                    {
                        184UL
                    }
                }
            };
            Register<_VI_DEADLOCK_RESOURCE>((mem, ptr) => new _VI_DEADLOCK_RESOURCE(mem, ptr), offsets);
        }
    }
}