using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CMHIVE")]
    public sealed class _CMHIVE : DynamicStructure
    {
        public _HHIVE Hive { get; }
        public byte[] FileHandles { get; }
        public _LIST_ENTRY NotifyList { get; }
        public _LIST_ENTRY HiveList { get; }
        public _LIST_ENTRY PreloadedHiveList { get; }
        public _EX_RUNDOWN_REF HiveRundown { get; }
        public IntPtr KcbCacheTable { get; }
        public uint KcbCacheTableSize { get; }
        public IntPtr DeletedKcbTable { get; }
        public uint DeletedKcbTableSize { get; }
        public uint Identity { get; }
        public _CMSI_RW_LOCK HiveLock { get; }
        public _RTL_BITMAP FlushDirtyVector { get; }
        public uint FlushDirtyVectorSize { get; }
        public IntPtr FlushLogEntryOffsetArray { get; }
        public uint FlushLogEntryOffsetArrayCount { get; }
        public uint FlushLogEntrySize { get; }
        public uint FlushHiveTruncated { get; }
        public byte FlushBaseBlockDirty { get; }
        public _RTL_BITMAP CapturedUnreconciledVector { get; }
        public uint CapturedUnreconciledVectorSize { get; }
        public IntPtr UnreconciledOffsetArray { get; }
        public uint UnreconciledOffsetArrayCount { get; }
        public IntPtr UnreconciledBaseBlock { get; }
        public _EX_PUSH_LOCK SecurityLock { get; }
        public uint LastShrinkHiveSize { get; }
        public _LARGE_INTEGER ActualFileSize { get; }
        public byte[] LogFileSizes { get; }
        public _UNICODE_STRING FileFullPath { get; }
        public _UNICODE_STRING FileUserName { get; }
        public _UNICODE_STRING HiveRootPath { get; }
        public uint SecurityCount { get; }
        public uint SecurityCacheSize { get; }
        public int SecurityHitHint { get; }
        public IntPtr SecurityCache { get; }
        public byte[] SecurityHash { get; }
        public uint UnloadEventCount { get; }
        public IntPtr UnloadEventArray { get; }
        public IntPtr RootKcb { get; }
        public byte Frozen { get; }
        public _CM_DIRTY_VECTOR_LOG DirtyVectorLog { get; }
        public uint Flags { get; }
        public _LIST_ENTRY TrustClassEntry { get; }
        public ulong DirtyTime { get; }
        public ulong UnreconciledTime { get; }
        public IntPtr CmRm { get; }
        public uint CmRmInitFailPoint { get; }
        public int CmRmInitFailStatus { get; }
        public IntPtr CreatorOwner { get; }
        public IntPtr RundownThread { get; }
        public _LARGE_INTEGER LastWriteTime { get; }
        public _HIVE_WRITE_WAIT_QUEUE FlushQueue { get; }
        public _HIVE_WRITE_WAIT_QUEUE ReconcileQueue { get; }
        public uint FlushFlags { get; }
        public uint PrimaryFilePurged { get; }
        public uint DiskFileBad { get; }
        public uint PrimaryFileSizeBeforeLastFlush { get; }
        public int ReferenceCount { get; }
        public int UnloadHistoryIndex { get; }
        public uint[] UnloadHistory { get; }
        public uint BootStart { get; }
        public uint UnaccessedStart { get; }
        public uint UnaccessedEnd { get; }
        public uint LoadedKeyCount { get; }
        public uint HandleClosePending { get; }
        public _EX_PUSH_LOCK HandleClosePendingEvent { get; }
        public byte FinalFlushSucceeded { get; }
        public IntPtr VolumeContext { get; }
        public uint LateUnloadWorkItemState { get; }
        public _EX_PUSH_LOCK LateUnloadFinishedEvent { get; }
        public IntPtr LateUnloadWorkItem { get; }

        public _CMHIVE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CMHIVE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CMHIVE.Hive),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CMHIVE.FileHandles),
                    new ulong[]
                    {
                        1544UL
                    }
                },
                {
                    nameof(_CMHIVE.NotifyList),
                    new ulong[]
                    {
                        1592UL
                    }
                },
                {
                    nameof(_CMHIVE.HiveList),
                    new ulong[]
                    {
                        1608UL
                    }
                },
                {
                    nameof(_CMHIVE.PreloadedHiveList),
                    new ulong[]
                    {
                        1624UL
                    }
                },
                {
                    nameof(_CMHIVE.HiveRundown),
                    new ulong[]
                    {
                        1640UL
                    }
                },
                {
                    nameof(_CMHIVE.KcbCacheTable),
                    new ulong[]
                    {
                        1648UL
                    }
                },
                {
                    nameof(_CMHIVE.KcbCacheTableSize),
                    new ulong[]
                    {
                        1656UL
                    }
                },
                {
                    nameof(_CMHIVE.DeletedKcbTable),
                    new ulong[]
                    {
                        1664UL
                    }
                },
                {
                    nameof(_CMHIVE.DeletedKcbTableSize),
                    new ulong[]
                    {
                        1672UL
                    }
                },
                {
                    nameof(_CMHIVE.Identity),
                    new ulong[]
                    {
                        1676UL
                    }
                },
                {
                    nameof(_CMHIVE.HiveLock),
                    new ulong[]
                    {
                        1680UL
                    }
                },
                {
                    nameof(_CMHIVE.FlushDirtyVector),
                    new ulong[]
                    {
                        1688UL
                    }
                },
                {
                    nameof(_CMHIVE.FlushDirtyVectorSize),
                    new ulong[]
                    {
                        1704UL
                    }
                },
                {
                    nameof(_CMHIVE.FlushLogEntryOffsetArray),
                    new ulong[]
                    {
                        1712UL
                    }
                },
                {
                    nameof(_CMHIVE.FlushLogEntryOffsetArrayCount),
                    new ulong[]
                    {
                        1720UL
                    }
                },
                {
                    nameof(_CMHIVE.FlushLogEntrySize),
                    new ulong[]
                    {
                        1724UL
                    }
                },
                {
                    nameof(_CMHIVE.FlushHiveTruncated),
                    new ulong[]
                    {
                        1728UL
                    }
                },
                {
                    nameof(_CMHIVE.FlushBaseBlockDirty),
                    new ulong[]
                    {
                        1732UL
                    }
                },
                {
                    nameof(_CMHIVE.CapturedUnreconciledVector),
                    new ulong[]
                    {
                        1736UL
                    }
                },
                {
                    nameof(_CMHIVE.CapturedUnreconciledVectorSize),
                    new ulong[]
                    {
                        1752UL
                    }
                },
                {
                    nameof(_CMHIVE.UnreconciledOffsetArray),
                    new ulong[]
                    {
                        1760UL
                    }
                },
                {
                    nameof(_CMHIVE.UnreconciledOffsetArrayCount),
                    new ulong[]
                    {
                        1768UL
                    }
                },
                {
                    nameof(_CMHIVE.UnreconciledBaseBlock),
                    new ulong[]
                    {
                        1776UL
                    }
                },
                {
                    nameof(_CMHIVE.SecurityLock),
                    new ulong[]
                    {
                        1784UL
                    }
                },
                {
                    nameof(_CMHIVE.LastShrinkHiveSize),
                    new ulong[]
                    {
                        1792UL
                    }
                },
                {
                    nameof(_CMHIVE.ActualFileSize),
                    new ulong[]
                    {
                        1800UL
                    }
                },
                {
                    nameof(_CMHIVE.LogFileSizes),
                    new ulong[]
                    {
                        1808UL
                    }
                },
                {
                    nameof(_CMHIVE.FileFullPath),
                    new ulong[]
                    {
                        1824UL
                    }
                },
                {
                    nameof(_CMHIVE.FileUserName),
                    new ulong[]
                    {
                        1840UL
                    }
                },
                {
                    nameof(_CMHIVE.HiveRootPath),
                    new ulong[]
                    {
                        1856UL
                    }
                },
                {
                    nameof(_CMHIVE.SecurityCount),
                    new ulong[]
                    {
                        1872UL
                    }
                },
                {
                    nameof(_CMHIVE.SecurityCacheSize),
                    new ulong[]
                    {
                        1876UL
                    }
                },
                {
                    nameof(_CMHIVE.SecurityHitHint),
                    new ulong[]
                    {
                        1880UL
                    }
                },
                {
                    nameof(_CMHIVE.SecurityCache),
                    new ulong[]
                    {
                        1888UL
                    }
                },
                {
                    nameof(_CMHIVE.SecurityHash),
                    new ulong[]
                    {
                        1896UL
                    }
                },
                {
                    nameof(_CMHIVE.UnloadEventCount),
                    new ulong[]
                    {
                        2920UL
                    }
                },
                {
                    nameof(_CMHIVE.UnloadEventArray),
                    new ulong[]
                    {
                        2928UL
                    }
                },
                {
                    nameof(_CMHIVE.RootKcb),
                    new ulong[]
                    {
                        2936UL
                    }
                },
                {
                    nameof(_CMHIVE.Frozen),
                    new ulong[]
                    {
                        2944UL
                    }
                },
                {
                    nameof(_CMHIVE.DirtyVectorLog),
                    new ulong[]
                    {
                        2952UL
                    }
                },
                {
                    nameof(_CMHIVE.Flags),
                    new ulong[]
                    {
                        4112UL
                    }
                },
                {
                    nameof(_CMHIVE.TrustClassEntry),
                    new ulong[]
                    {
                        4120UL
                    }
                },
                {
                    nameof(_CMHIVE.DirtyTime),
                    new ulong[]
                    {
                        4136UL
                    }
                },
                {
                    nameof(_CMHIVE.UnreconciledTime),
                    new ulong[]
                    {
                        4144UL
                    }
                },
                {
                    nameof(_CMHIVE.CmRm),
                    new ulong[]
                    {
                        4152UL
                    }
                },
                {
                    nameof(_CMHIVE.CmRmInitFailPoint),
                    new ulong[]
                    {
                        4160UL
                    }
                },
                {
                    nameof(_CMHIVE.CmRmInitFailStatus),
                    new ulong[]
                    {
                        4164UL
                    }
                },
                {
                    nameof(_CMHIVE.CreatorOwner),
                    new ulong[]
                    {
                        4168UL
                    }
                },
                {
                    nameof(_CMHIVE.RundownThread),
                    new ulong[]
                    {
                        4176UL
                    }
                },
                {
                    nameof(_CMHIVE.LastWriteTime),
                    new ulong[]
                    {
                        4184UL
                    }
                },
                {
                    nameof(_CMHIVE.FlushQueue),
                    new ulong[]
                    {
                        4192UL
                    }
                },
                {
                    nameof(_CMHIVE.ReconcileQueue),
                    new ulong[]
                    {
                        4208UL
                    }
                },
                {
                    nameof(_CMHIVE.FlushFlags),
                    new ulong[]
                    {
                        4224UL
                    }
                },
                {
                    nameof(_CMHIVE.PrimaryFilePurged),
                    new ulong[]
                    {
                        4224UL
                    }
                },
                {
                    nameof(_CMHIVE.DiskFileBad),
                    new ulong[]
                    {
                        4224UL
                    }
                },
                {
                    nameof(_CMHIVE.PrimaryFileSizeBeforeLastFlush),
                    new ulong[]
                    {
                        4228UL
                    }
                },
                {
                    nameof(_CMHIVE.ReferenceCount),
                    new ulong[]
                    {
                        4232UL
                    }
                },
                {
                    nameof(_CMHIVE.UnloadHistoryIndex),
                    new ulong[]
                    {
                        4236UL
                    }
                },
                {
                    nameof(_CMHIVE.UnloadHistory),
                    new ulong[]
                    {
                        4240UL
                    }
                },
                {
                    nameof(_CMHIVE.BootStart),
                    new ulong[]
                    {
                        4752UL
                    }
                },
                {
                    nameof(_CMHIVE.UnaccessedStart),
                    new ulong[]
                    {
                        4756UL
                    }
                },
                {
                    nameof(_CMHIVE.UnaccessedEnd),
                    new ulong[]
                    {
                        4760UL
                    }
                },
                {
                    nameof(_CMHIVE.LoadedKeyCount),
                    new ulong[]
                    {
                        4764UL
                    }
                },
                {
                    nameof(_CMHIVE.HandleClosePending),
                    new ulong[]
                    {
                        4768UL
                    }
                },
                {
                    nameof(_CMHIVE.HandleClosePendingEvent),
                    new ulong[]
                    {
                        4776UL
                    }
                },
                {
                    nameof(_CMHIVE.FinalFlushSucceeded),
                    new ulong[]
                    {
                        4784UL
                    }
                },
                {
                    nameof(_CMHIVE.VolumeContext),
                    new ulong[]
                    {
                        4792UL
                    }
                },
                {
                    nameof(_CMHIVE.LateUnloadWorkItemState),
                    new ulong[]
                    {
                        4800UL
                    }
                },
                {
                    nameof(_CMHIVE.LateUnloadFinishedEvent),
                    new ulong[]
                    {
                        4808UL
                    }
                },
                {
                    nameof(_CMHIVE.LateUnloadWorkItem),
                    new ulong[]
                    {
                        4816UL
                    }
                }
            };
            Register<_CMHIVE>((mem, ptr) => new _CMHIVE(mem, ptr), offsets);
        }
    }
}