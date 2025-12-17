using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VI_DEADLOCK_NODE")]
    public sealed class _VI_DEADLOCK_NODE : DynamicStructure
    {
        public IntPtr Parent { get; }
        public _LIST_ENTRY ChildrenList { get; }
        public _LIST_ENTRY SiblingsList { get; }
        public _LIST_ENTRY ResourceList { get; }
        public _LIST_ENTRY FreeListEntry { get; }
        public IntPtr Root { get; }
        public IntPtr ThreadEntry { get; }
        public _unnamed_tag_ u1 { get; }
        public int ChildrenCount { get; }
        public byte[] StackTrace { get; }
        public byte[] ParentStackTrace { get; }

        public _VI_DEADLOCK_NODE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VI_DEADLOCK_NODE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VI_DEADLOCK_NODE.Parent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_NODE.ChildrenList),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_NODE.SiblingsList),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_NODE.ResourceList),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_NODE.FreeListEntry),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_NODE.Root),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_NODE.ThreadEntry),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_NODE.u1),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_NODE.ChildrenCount),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_NODE.StackTrace),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_VI_DEADLOCK_NODE.ParentStackTrace),
                    new ulong[]
                    {
                        144UL
                    }
                }
            };
            Register<_VI_DEADLOCK_NODE>((mem, ptr) => new _VI_DEADLOCK_NODE(mem, ptr), offsets);
        }
    }
}