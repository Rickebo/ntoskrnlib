using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TPP_CLEANUP_GROUP_MEMBER")]
    public sealed class _TPP_CLEANUP_GROUP_MEMBER : DynamicStructure
    {
        public _TPP_REFCOUNT Refcount { get; }
        public IntPtr VFuncs { get; }
        public IntPtr CleanupGroup { get; }
        public IntPtr CleanupGroupCancelCallback { get; }
        public IntPtr FinalizationCallback { get; }
        public _LIST_ENTRY CleanupGroupMemberLinks { get; }
        public _TPP_BARRIER CallbackBarrier { get; }
        public IntPtr Callback { get; }
        public IntPtr WorkCallback { get; }
        public IntPtr SimpleCallback { get; }
        public IntPtr TimerCallback { get; }
        public IntPtr WaitCallback { get; }
        public IntPtr IoCallback { get; }
        public IntPtr AlpcCallback { get; }
        public IntPtr AlpcCallbackEx { get; }
        public IntPtr JobCallback { get; }
        public IntPtr Context { get; }
        public IntPtr ActivationContext { get; }
        public IntPtr SubProcessTag { get; }
        public _GUID ActivityId { get; }
        public _ALPC_WORK_ON_BEHALF_TICKET WorkOnBehalfTicket { get; }
        public IntPtr RaceDll { get; }
        public IntPtr Pool { get; }
        public _LIST_ENTRY PoolObjectLinks { get; }
        public int Flags { get; }
        public uint LongFunction { get; }
        public uint Persistent { get; }
        public uint UnusedPublic { get; }
        public uint Released { get; }
        public uint CleanupGroupReleased { get; }
        public uint InCleanupGroupCleanupList { get; }
        public uint UnusedPrivate { get; }
        public _TPP_CALLER AllocCaller { get; }
        public _TPP_CALLER ReleaseCaller { get; }
        public uint CallbackPriority { get; }

        public _TPP_CLEANUP_GROUP_MEMBER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TPP_CLEANUP_GROUP_MEMBER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.Refcount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.VFuncs),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.CleanupGroup),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.CleanupGroupCancelCallback),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.FinalizationCallback),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.CleanupGroupMemberLinks),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.CallbackBarrier),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.Callback),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.WorkCallback),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.SimpleCallback),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.TimerCallback),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.WaitCallback),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.IoCallback),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.AlpcCallback),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.AlpcCallbackEx),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.JobCallback),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.Context),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.ActivationContext),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.SubProcessTag),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.ActivityId),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.WorkOnBehalfTicket),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.RaceDll),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.Pool),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.PoolObjectLinks),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.Flags),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.LongFunction),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.Persistent),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.UnusedPublic),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.Released),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.CleanupGroupReleased),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.InCleanupGroupCleanupList),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.UnusedPrivate),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.AllocCaller),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.ReleaseCaller),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_TPP_CLEANUP_GROUP_MEMBER.CallbackPriority),
                    new ulong[]
                    {
                        192UL
                    }
                }
            };
            Register<_TPP_CLEANUP_GROUP_MEMBER>((mem, ptr) => new _TPP_CLEANUP_GROUP_MEMBER(mem, ptr), offsets);
        }
    }
}