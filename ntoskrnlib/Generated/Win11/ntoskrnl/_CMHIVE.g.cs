#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4824)]
    public partial struct _CMHIVE
    {
        [FieldOffset(0)]
        public _HHIVE Hive;
        [FieldOffset(1544)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public IntPtr[] FileHandles;
        [FieldOffset(1592)]
        public _LIST_ENTRY NotifyList;
        [FieldOffset(1608)]
        public _LIST_ENTRY HiveList;
        [FieldOffset(1624)]
        public _LIST_ENTRY PreloadedHiveList;
        [FieldOffset(1640)]
        public _EX_RUNDOWN_REF HiveRundown;
        [FieldOffset(1648)]
        public IntPtr KcbCacheTable;
        [FieldOffset(1656)]
        public uint KcbCacheTableSize;
        [FieldOffset(1664)]
        public IntPtr DeletedKcbTable;
        [FieldOffset(1672)]
        public uint DeletedKcbTableSize;
        [FieldOffset(1676)]
        public uint Identity;
        [FieldOffset(1680)]
        public _CMSI_RW_LOCK HiveLock;
        [FieldOffset(1688)]
        public _RTL_BITMAP FlushDirtyVector;
        [FieldOffset(1704)]
        public uint FlushDirtyVectorSize;
        [FieldOffset(1712)]
        public IntPtr FlushLogEntryOffsetArray;
        [FieldOffset(1720)]
        public uint FlushLogEntryOffsetArrayCount;
        [FieldOffset(1724)]
        public uint FlushLogEntrySize;
        [FieldOffset(1728)]
        public uint FlushHiveTruncated;
        [FieldOffset(1732)]
        public byte FlushBaseBlockDirty;
        [FieldOffset(1736)]
        public _RTL_BITMAP CapturedUnreconciledVector;
        [FieldOffset(1752)]
        public uint CapturedUnreconciledVectorSize;
        [FieldOffset(1760)]
        public IntPtr UnreconciledOffsetArray;
        [FieldOffset(1768)]
        public uint UnreconciledOffsetArrayCount;
        [FieldOffset(1776)]
        public IntPtr UnreconciledBaseBlock;
        [FieldOffset(1784)]
        public _EX_PUSH_LOCK SecurityLock;
        [FieldOffset(1792)]
        public uint LastShrinkHiveSize;
        [FieldOffset(1800)]
        public _LARGE_INTEGER ActualFileSize;
        [FieldOffset(1808)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _LARGE_INTEGER[] LogFileSizes;
        [FieldOffset(1824)]
        public _UNICODE_STRING FileFullPath;
        [FieldOffset(1840)]
        public _UNICODE_STRING FileUserName;
        [FieldOffset(1856)]
        public _UNICODE_STRING HiveRootPath;
        [FieldOffset(1872)]
        public uint SecurityCount;
        [FieldOffset(1876)]
        public uint SecurityCacheSize;
        [FieldOffset(1880)]
        public int SecurityHitHint;
        [FieldOffset(1888)]
        public IntPtr SecurityCache;
        [FieldOffset(1896)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public _LIST_ENTRY[] SecurityHash;
        [FieldOffset(2920)]
        public uint UnloadEventCount;
        [FieldOffset(2928)]
        public IntPtr UnloadEventArray;
        [FieldOffset(2936)]
        public IntPtr RootKcb;
        [FieldOffset(2944)]
        public byte Frozen;
        [FieldOffset(2952)]
        public _CM_DIRTY_VECTOR_LOG DirtyVectorLog;
        [FieldOffset(4112)]
        public uint Flags;
        [FieldOffset(4120)]
        public _LIST_ENTRY TrustClassEntry;
        [FieldOffset(4136)]
        public ulong DirtyTime;
        [FieldOffset(4144)]
        public ulong UnreconciledTime;
        [FieldOffset(4152)]
        public IntPtr CmRm;
        [FieldOffset(4160)]
        public uint CmRmInitFailPoint;
        [FieldOffset(4164)]
        public int CmRmInitFailStatus;
        [FieldOffset(4168)]
        public IntPtr CreatorOwner;
        [FieldOffset(4176)]
        public IntPtr RundownThread;
        [FieldOffset(4184)]
        public _LARGE_INTEGER LastWriteTime;
        [FieldOffset(4192)]
        public _HIVE_WRITE_WAIT_QUEUE FlushQueue;
        [FieldOffset(4208)]
        public _HIVE_WRITE_WAIT_QUEUE ReconcileQueue;
        [FieldOffset(4224)]
        public uint FlushFlags;
        [FieldOffset(4224)]
        public uint PrimaryFilePurged;
        [FieldOffset(4224)]
        public uint DiskFileBad;
        [FieldOffset(4228)]
        public uint PrimaryFileSizeBeforeLastFlush;
        [FieldOffset(4232)]
        public int ReferenceCount;
        [FieldOffset(4236)]
        public int UnloadHistoryIndex;
        [FieldOffset(4240)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public uint[] UnloadHistory;
        [FieldOffset(4752)]
        public uint BootStart;
        [FieldOffset(4756)]
        public uint UnaccessedStart;
        [FieldOffset(4760)]
        public uint UnaccessedEnd;
        [FieldOffset(4764)]
        public uint LoadedKeyCount;
        [FieldOffset(4768)]
        public uint HandleClosePending;
        [FieldOffset(4776)]
        public _EX_PUSH_LOCK HandleClosePendingEvent;
        [FieldOffset(4784)]
        public byte FinalFlushSucceeded;
        [FieldOffset(4792)]
        public IntPtr VolumeContext;
        [FieldOffset(4800)]
        public uint LateUnloadWorkItemState;
        [FieldOffset(4808)]
        public _EX_PUSH_LOCK LateUnloadFinishedEvent;
        [FieldOffset(4816)]
        public IntPtr LateUnloadWorkItem;
    }
}