#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 960)]
    public partial struct _KTM
    {
        [FieldOffset(0)]
        public uint cookie;
        [FieldOffset(8)]
        public _KMUTANT Mutex;
        [FieldOffset(64)]
        public uint State;
        [FieldOffset(72)]
        public _KTMOBJECT_NAMESPACE_LINK NamespaceLink;
        [FieldOffset(112)]
        public _GUID TmIdentity;
        [FieldOffset(128)]
        public uint Flags;
        [FieldOffset(132)]
        public uint VolatileFlags;
        [FieldOffset(136)]
        public _UNICODE_STRING LogFileName;
        [FieldOffset(152)]
        public IntPtr LogFileObject;
        [FieldOffset(160)]
        public IntPtr MarshallingContext;
        [FieldOffset(168)]
        public IntPtr LogManagementContext;
        [FieldOffset(176)]
        public _KTMOBJECT_NAMESPACE Transactions;
        [FieldOffset(344)]
        public _KTMOBJECT_NAMESPACE ResourceManagers;
        [FieldOffset(512)]
        public _KMUTANT LsnOrderedMutex;
        [FieldOffset(568)]
        public _LIST_ENTRY LsnOrderedList;
        [FieldOffset(584)]
        public _LARGE_INTEGER CommitVirtualClock;
        [FieldOffset(592)]
        public _FAST_MUTEX CommitVirtualClockMutex;
        [FieldOffset(648)]
        public _CLS_LSN BaseLsn;
        [FieldOffset(656)]
        public _CLS_LSN CurrentReadLsn;
        [FieldOffset(664)]
        public _CLS_LSN LastRecoveredLsn;
        [FieldOffset(672)]
        public IntPtr TmRmHandle;
        [FieldOffset(680)]
        public IntPtr TmRm;
        [FieldOffset(688)]
        public _KEVENT LogFullNotifyEvent;
        [FieldOffset(712)]
        public _WORK_QUEUE_ITEM CheckpointWorkItem;
        [FieldOffset(744)]
        public _CLS_LSN CheckpointTargetLsn;
        [FieldOffset(752)]
        public _WORK_QUEUE_ITEM LogFullCompletedWorkItem;
        [FieldOffset(784)]
        public _ERESOURCE LogWriteResource;
        [FieldOffset(888)]
        public uint LogFlags;
        [FieldOffset(892)]
        public int LogFullStatus;
        [FieldOffset(896)]
        public int RecoveryStatus;
        [FieldOffset(904)]
        public _CLS_LSN LastCheckBaseLsn;
        [FieldOffset(912)]
        public _LIST_ENTRY RestartOrderedList;
        [FieldOffset(928)]
        public _WORK_QUEUE_ITEM OfflineWorkItem;
    }
}