using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KTM")]
    public sealed class _KTM : DynamicStructure
    {
        public uint cookie { get; }
        public _KMUTANT Mutex { get; }
        public uint State { get; }
        public _KTMOBJECT_NAMESPACE_LINK NamespaceLink { get; }
        public _GUID TmIdentity { get; }
        public uint Flags { get; }
        public uint VolatileFlags { get; }
        public _UNICODE_STRING LogFileName { get; }
        public IntPtr LogFileObject { get; }
        public IntPtr MarshallingContext { get; }
        public IntPtr LogManagementContext { get; }
        public _KTMOBJECT_NAMESPACE Transactions { get; }
        public _KTMOBJECT_NAMESPACE ResourceManagers { get; }
        public _KMUTANT LsnOrderedMutex { get; }
        public _LIST_ENTRY LsnOrderedList { get; }
        public _LARGE_INTEGER CommitVirtualClock { get; }
        public _FAST_MUTEX CommitVirtualClockMutex { get; }
        public _CLS_LSN BaseLsn { get; }
        public _CLS_LSN CurrentReadLsn { get; }
        public _CLS_LSN LastRecoveredLsn { get; }
        public IntPtr TmRmHandle { get; }
        public IntPtr TmRm { get; }
        public _KEVENT LogFullNotifyEvent { get; }
        public _WORK_QUEUE_ITEM CheckpointWorkItem { get; }
        public _CLS_LSN CheckpointTargetLsn { get; }
        public _WORK_QUEUE_ITEM LogFullCompletedWorkItem { get; }
        public _ERESOURCE LogWriteResource { get; }
        public uint LogFlags { get; }
        public int LogFullStatus { get; }
        public int RecoveryStatus { get; }
        public _CLS_LSN LastCheckBaseLsn { get; }
        public _LIST_ENTRY RestartOrderedList { get; }
        public _WORK_QUEUE_ITEM OfflineWorkItem { get; }

        public _KTM(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KTM()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KTM.cookie),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KTM.Mutex),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KTM.State),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KTM.NamespaceLink),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_KTM.TmIdentity),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_KTM.Flags),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_KTM.VolatileFlags),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_KTM.LogFileName),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KTM.LogFileObject),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_KTM.MarshallingContext),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_KTM.LogManagementContext),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_KTM.Transactions),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_KTM.ResourceManagers),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_KTM.LsnOrderedMutex),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_KTM.LsnOrderedList),
                    new ulong[]
                    {
                        568UL
                    }
                },
                {
                    nameof(_KTM.CommitVirtualClock),
                    new ulong[]
                    {
                        584UL
                    }
                },
                {
                    nameof(_KTM.CommitVirtualClockMutex),
                    new ulong[]
                    {
                        592UL
                    }
                },
                {
                    nameof(_KTM.BaseLsn),
                    new ulong[]
                    {
                        648UL
                    }
                },
                {
                    nameof(_KTM.CurrentReadLsn),
                    new ulong[]
                    {
                        656UL
                    }
                },
                {
                    nameof(_KTM.LastRecoveredLsn),
                    new ulong[]
                    {
                        664UL
                    }
                },
                {
                    nameof(_KTM.TmRmHandle),
                    new ulong[]
                    {
                        672UL
                    }
                },
                {
                    nameof(_KTM.TmRm),
                    new ulong[]
                    {
                        680UL
                    }
                },
                {
                    nameof(_KTM.LogFullNotifyEvent),
                    new ulong[]
                    {
                        688UL
                    }
                },
                {
                    nameof(_KTM.CheckpointWorkItem),
                    new ulong[]
                    {
                        712UL
                    }
                },
                {
                    nameof(_KTM.CheckpointTargetLsn),
                    new ulong[]
                    {
                        744UL
                    }
                },
                {
                    nameof(_KTM.LogFullCompletedWorkItem),
                    new ulong[]
                    {
                        752UL
                    }
                },
                {
                    nameof(_KTM.LogWriteResource),
                    new ulong[]
                    {
                        784UL
                    }
                },
                {
                    nameof(_KTM.LogFlags),
                    new ulong[]
                    {
                        888UL
                    }
                },
                {
                    nameof(_KTM.LogFullStatus),
                    new ulong[]
                    {
                        892UL
                    }
                },
                {
                    nameof(_KTM.RecoveryStatus),
                    new ulong[]
                    {
                        896UL
                    }
                },
                {
                    nameof(_KTM.LastCheckBaseLsn),
                    new ulong[]
                    {
                        904UL
                    }
                },
                {
                    nameof(_KTM.RestartOrderedList),
                    new ulong[]
                    {
                        912UL
                    }
                },
                {
                    nameof(_KTM.OfflineWorkItem),
                    new ulong[]
                    {
                        928UL
                    }
                }
            };
            Register<_KTM>((mem, ptr) => new _KTM(mem, ptr), offsets);
        }
    }
}