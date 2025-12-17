using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TP_WORK")]
    public sealed class _TP_WORK : DynamicStructure
    {
        public _TPP_CLEANUP_GROUP_MEMBER CleanupGroupMember { get; }
        public _TP_TASK Task { get; }
        public _TPP_WORK_STATE WorkState { get; }

        public _TP_WORK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TP_WORK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TP_WORK.CleanupGroupMember),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TP_WORK.Task),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_TP_WORK.WorkState),
                    new ulong[]
                    {
                        232UL
                    }
                }
            };
            Register<_TP_WORK>((mem, ptr) => new _TP_WORK(mem, ptr), offsets);
        }
    }
}