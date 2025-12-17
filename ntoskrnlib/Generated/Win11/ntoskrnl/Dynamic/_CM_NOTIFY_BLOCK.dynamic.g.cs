using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_NOTIFY_BLOCK")]
    public sealed class _CM_NOTIFY_BLOCK : DynamicStructure
    {
        public _LIST_ENTRY HiveList { get; }
        public _LIST_ENTRY PostList { get; }
        public IntPtr KeyControlBlock { get; }
        public IntPtr KeyBody { get; }
        public uint Filter { get; }
        public uint WatchTree { get; }
        public uint NotifyPending { get; }
        public _SECURITY_SUBJECT_CONTEXT SubjectContext { get; }

        public _CM_NOTIFY_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_NOTIFY_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_NOTIFY_BLOCK.HiveList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_NOTIFY_BLOCK.PostList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CM_NOTIFY_BLOCK.KeyControlBlock),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_CM_NOTIFY_BLOCK.KeyBody),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_CM_NOTIFY_BLOCK.Filter),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_NOTIFY_BLOCK.WatchTree),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_NOTIFY_BLOCK.NotifyPending),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_NOTIFY_BLOCK.SubjectContext),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_CM_NOTIFY_BLOCK>((mem, ptr) => new _CM_NOTIFY_BLOCK(mem, ptr), offsets);
        }
    }
}