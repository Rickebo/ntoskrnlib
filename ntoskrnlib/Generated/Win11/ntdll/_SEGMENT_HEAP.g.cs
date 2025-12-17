#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 2560)]
    public partial struct _SEGMENT_HEAP
    {
        [FieldOffset(0)]
        public RTL_HP_ENV_HANDLE EnvHandle;
        [FieldOffset(16)]
        public uint Signature;
        [FieldOffset(20)]
        public uint GlobalFlags;
        [FieldOffset(24)]
        public uint Interceptor;
        [FieldOffset(28)]
        public ushort ProcessHeapListIndex;
        [FieldOffset(30)]
        public ushort AllocatedFromMetadata;
        [FieldOffset(30)]
        public ushort ReadOnly;
        [FieldOffset(30)]
        public ushort InternalFlags;
        [FieldOffset(32)]
        public _RTLP_HEAP_COMMIT_LIMIT_DATA CommitLimitData;
        [FieldOffset(48)]
        public ulong ReservedMustBeZero;
        [FieldOffset(56)]
        public IntPtr UserContext;
        [FieldOffset(64)]
        public ulong LargeMetadataLock;
        [FieldOffset(72)]
        public _RTL_RB_TREE LargeAllocMetadata;
        [FieldOffset(88)]
        public ulong LargeReservedPages;
        [FieldOffset(96)]
        public ulong LargeCommittedPages;
        [FieldOffset(104)]
        public ulong Tag;
        [FieldOffset(112)]
        public _RTL_RUN_ONCE StackTraceInitVar;
        [FieldOffset(128)]
        public _HEAP_RUNTIME_MEMORY_STATS MemStats;
        [FieldOffset(224)]
        public uint GlobalLockOwner;
        [FieldOffset(232)]
        public ulong ContextExtendLock;
        [FieldOffset(240)]
        public IntPtr AllocatedBase;
        [FieldOffset(248)]
        public IntPtr UncommittedBase;
        [FieldOffset(256)]
        public IntPtr ReservedLimit;
        [FieldOffset(264)]
        public IntPtr ReservedRegionEnd;
        [FieldOffset(272)]
        public _RTL_HP_HEAP_VA_CALLBACKS_ENCODED CallbacksEncoded;
        [FieldOffset(320)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public _HEAP_SEG_CONTEXT[] SegContexts;
        [FieldOffset(704)]
        public _HEAP_VS_CONTEXT VsContext;
        [FieldOffset(832)]
        public _HEAP_LFH_CONTEXT LfhContext;
    }
}