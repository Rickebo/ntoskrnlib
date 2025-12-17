using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TP_CALLBACK_INSTANCE")]
    public sealed class _TP_CALLBACK_INSTANCE : DynamicStructure
    {
        public _RTL_CALLER_ALLOCATED_ACTIVATION_CONTEXT_STACK_FRAME_EXTENDED ActivationFrame { get; }
        public uint CallbackRunType { get; }
        public byte ActivationFrameUsed { get; }
        public byte Disassociated { get; }
        public byte UnrecoverableErrorDetected { get; }
        public IntPtr SubProcessTag { get; }
        public IntPtr Callback { get; }
        public IntPtr WorkCallback { get; }
        public IntPtr SimpleCallback { get; }
        public IntPtr TimerCallback { get; }
        public IntPtr WaitCallback { get; }
        public IntPtr IoCallback { get; }
        public IntPtr AlpcCallback { get; }
        public IntPtr AlpcCallbackEx { get; }
        public IntPtr JobCallback { get; }
        public IntPtr FinalizationCallback { get; }
        public IntPtr DirectCallback { get; }
        public IntPtr TaskCallback { get; }
        public IntPtr Context { get; }
        public uint SkipPostThreadFlags { get; }
        public uint SPActFrame { get; }
        public uint SPSubProcTag { get; }
        public uint SPImpersonation { get; }
        public uint SPThreadInfo { get; }
        public uint SPTransaction { get; }
        public uint SPLdrLock { get; }
        public uint SPLanguages { get; }
        public uint SPThreadPriBack { get; }
        public uint VerifyThreadFlags { get; }
        public uint VThreadInfo { get; }
        public int PreCallThrdPriority { get; }
        public ulong PreCallThrdAffinity { get; }
        public IntPtr Pool { get; }
        public IntPtr AlpcWorkItem { get; }
        public uint CallbackEpilogFlags { get; }
        public uint Event { get; }
        public uint Mutex { get; }
        public uint Semaphore { get; }
        public uint SemaphoreReleaseCount { get; }
        public IntPtr RaceDll { get; }
        public IntPtr CleanupGroup { get; }
        public IntPtr CleanupGroupMember { get; }
        public IntPtr CriticalSection { get; }
        public IntPtr DllHandle { get; }
        public _WORKER_FACTORY_DEFERRED_WORK DeferredWork { get; }
        public _GUID PreviousActivityId { get; }
        public ulong WorkOnBehalf { get; }

        public _TP_CALLBACK_INSTANCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TP_CALLBACK_INSTANCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TP_CALLBACK_INSTANCE.ActivationFrame),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.CallbackRunType),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.ActivationFrameUsed),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.Disassociated),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.UnrecoverableErrorDetected),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.SubProcessTag),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.Callback),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.WorkCallback),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.SimpleCallback),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.TimerCallback),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.WaitCallback),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.IoCallback),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.AlpcCallback),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.AlpcCallbackEx),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.JobCallback),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.FinalizationCallback),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.DirectCallback),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.TaskCallback),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.Context),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.SkipPostThreadFlags),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.SPActFrame),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.SPSubProcTag),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.SPImpersonation),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.SPThreadInfo),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.SPTransaction),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.SPLdrLock),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.SPLanguages),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.SPThreadPriBack),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.VerifyThreadFlags),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.VThreadInfo),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.PreCallThrdPriority),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.PreCallThrdAffinity),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.Pool),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.AlpcWorkItem),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.CallbackEpilogFlags),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.Event),
                    new ulong[]
                    {
                        148UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.Mutex),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.Semaphore),
                    new ulong[]
                    {
                        156UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.SemaphoreReleaseCount),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.RaceDll),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.CleanupGroup),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.CleanupGroupMember),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.CriticalSection),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.DllHandle),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.DeferredWork),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.PreviousActivityId),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_TP_CALLBACK_INSTANCE.WorkOnBehalf),
                    new ulong[]
                    {
                        248UL
                    }
                }
            };
            Register<_TP_CALLBACK_INSTANCE>((mem, ptr) => new _TP_CALLBACK_INSTANCE(mem, ptr), offsets);
        }
    }
}