#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 616)]
    public partial struct _SHARED_CACHE_MAP
    {
        [FieldOffset(0)]
        public short NodeTypeCode;
        [FieldOffset(2)]
        public short NodeByteSize;
        [FieldOffset(4)]
        public uint OpenCount;
        [FieldOffset(8)]
        public _LARGE_INTEGER FileSize;
        [FieldOffset(16)]
        public _LIST_ENTRY BcbList;
        [FieldOffset(32)]
        public _LARGE_INTEGER SectionSize;
        [FieldOffset(40)]
        public _LARGE_INTEGER ValidDataLength;
        [FieldOffset(48)]
        public _LARGE_INTEGER ValidDataGoal;
        [FieldOffset(56)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public IntPtr[] InitialVacbs;
        [FieldOffset(88)]
        public IntPtr Vacbs;
        [FieldOffset(96)]
        public _EX_FAST_REF FileObjectFastRef;
        [FieldOffset(104)]
        public _EX_PUSH_LOCK VacbLock;
        [FieldOffset(112)]
        public uint DirtyPages;
        [FieldOffset(120)]
        public _LIST_ENTRY LoggedStreamLinks;
        [FieldOffset(136)]
        public _LIST_ENTRY SharedCacheMapLinks;
        [FieldOffset(152)]
        public uint Flags;
        [FieldOffset(156)]
        public uint Flags2;
        [FieldOffset(160)]
        public int Status;
        [FieldOffset(168)]
        public IntPtr Mbcb;
        [FieldOffset(176)]
        public IntPtr Section;
        [FieldOffset(184)]
        public IntPtr CreateEvent;
        [FieldOffset(192)]
        public IntPtr WaitOnActiveCount;
        [FieldOffset(200)]
        public uint PagesToWrite;
        [FieldOffset(208)]
        public long BeyondLastFlush;
        [FieldOffset(216)]
        public IntPtr Callbacks;
        [FieldOffset(216)]
        public IntPtr CallbacksEx;
        [FieldOffset(224)]
        public IntPtr LazyWriteContext;
        [FieldOffset(232)]
        public _LIST_ENTRY PrivateList;
        [FieldOffset(248)]
        public _LOGGED_STREAM_CALLBACK_V1 V1;
        [FieldOffset(248)]
        public _LOGGED_STREAM_CALLBACK_V2 V2;
        [FieldOffset(264)]
        public _LARGE_INTEGER LargestLSN;
        [FieldOffset(272)]
        public uint DirtyPageThreshold;
        [FieldOffset(276)]
        public uint LazyWritePassCount;
        [FieldOffset(280)]
        public IntPtr UninitializeEvent;
        [FieldOffset(288)]
        public _FAST_MUTEX BcbLock;
        [FieldOffset(344)]
        public _LARGE_INTEGER LastUnmapBehindOffset;
        [FieldOffset(352)]
        public _KEVENT Event;
        [FieldOffset(376)]
        public _LARGE_INTEGER HighWaterMappingOffset;
        [FieldOffset(384)]
        public _PRIVATE_CACHE_MAP PrivateCacheMap;
        [FieldOffset(504)]
        public IntPtr WriteBehindWorkQueueEntry;
        [FieldOffset(512)]
        public IntPtr VolumeCacheMap;
        [FieldOffset(520)]
        public uint ProcImagePathHash;
        [FieldOffset(524)]
        public uint WritesInProgress;
        [FieldOffset(528)]
        public uint AsyncReadRequestCount;
        [FieldOffset(536)]
        public IntPtr Partition;
        [FieldOffset(544)]
        public uint InternalRefCount;
        [FieldOffset(548)]
        public uint NumMappedVacb;
        [FieldOffset(552)]
        public uint NumActiveVacb;
        [FieldOffset(556)]
        public uint IdealNodeForWriteBehind;
        [FieldOffset(560)]
        public uint IdealNodeNumber;
        [FieldOffset(568)]
        public _LIST_ENTRY VolSharedCacheMapLinks;
        [FieldOffset(584)]
        public _LIST_ENTRY VolLoggedStreamLinks;
        [FieldOffset(600)]
        public IntPtr PrivateVolumeCacheMap;
        [FieldOffset(608)]
        public uint SectionSizeIncrement;
    }
}