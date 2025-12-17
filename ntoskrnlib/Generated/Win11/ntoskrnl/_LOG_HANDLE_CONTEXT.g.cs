#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 152)]
    public partial struct _LOG_HANDLE_CONTEXT
    {
        [FieldOffset(0)]
        public IntPtr LogHandle;
        [FieldOffset(8)]
        public IntPtr FlushToLsnRoutine;
        [FieldOffset(16)]
        public IntPtr QueryLogHandleInfoRoutine;
        [FieldOffset(24)]
        public _DIRTY_PAGE_STATISTICS DirtyPageStatistics;
        [FieldOffset(48)]
        public _DIRTY_PAGE_THRESHOLDS DirtyPageThresholds;
        [FieldOffset(104)]
        public uint AdditionalPagesToWrite;
        [FieldOffset(108)]
        public uint CcLWScanDPThreshold;
        [FieldOffset(112)]
        public _LARGE_INTEGER LargestLsnForCurrentLWScan;
        [FieldOffset(120)]
        public IntPtr RelatedFileObject;
        [FieldOffset(128)]
        public ulong LargestLsnFileObjectKey;
        [FieldOffset(136)]
        public _LARGE_INTEGER LastLWTimeStamp;
        [FieldOffset(144)]
        public uint Flags;
    }
}