using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TP_JOB")]
    public sealed class _TP_JOB : DynamicStructure
    {
        public _TP_DIRECT Direct { get; }
        public _TPP_CLEANUP_GROUP_MEMBER CleanupGroupMember { get; }
        public IntPtr JobHandle { get; }
        public long CompletionState { get; }
        public long Rundown { get; }
        public long CompletionCount { get; }
        public _RTL_SRWLOCK RundownLock { get; }

        public _TP_JOB(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TP_JOB()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TP_JOB.Direct),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TP_JOB.CleanupGroupMember),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_TP_JOB.JobHandle),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_TP_JOB.CompletionState),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_TP_JOB.Rundown),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_TP_JOB.CompletionCount),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_TP_JOB.RundownLock),
                    new ulong[]
                    {
                        288UL
                    }
                }
            };
            Register<_TP_JOB>((mem, ptr) => new _TP_JOB(mem, ptr), offsets);
        }
    }
}