using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TP_CLEANUP_GROUP")]
    public sealed class _TP_CLEANUP_GROUP : DynamicStructure
    {
        public _TPP_REFCOUNT Refcount { get; }
        public int Released { get; }
        public _RTL_SRWLOCK MemberLock { get; }
        public _LIST_ENTRY MemberList { get; }
        public _TPP_BARRIER Barrier { get; }
        public _RTL_SRWLOCK CleanupLock { get; }
        public _LIST_ENTRY CleanupList { get; }

        public _TP_CLEANUP_GROUP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TP_CLEANUP_GROUP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TP_CLEANUP_GROUP.Refcount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TP_CLEANUP_GROUP.Released),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_TP_CLEANUP_GROUP.MemberLock),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_TP_CLEANUP_GROUP.MemberList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_TP_CLEANUP_GROUP.Barrier),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_TP_CLEANUP_GROUP.CleanupLock),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_TP_CLEANUP_GROUP.CleanupList),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_TP_CLEANUP_GROUP>((mem, ptr) => new _TP_CLEANUP_GROUP(mem, ptr), offsets);
        }
    }
}