#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct _HEAP_SEGMENT_MGR_COMMIT_STATE
    {
        [FieldOffset(0)]
        public ushort CommittedPageCount;
        [FieldOffset(0)]
        public ushort Spare;
        [FieldOffset(0)]
        public ushort LargePageOperationInProgress;
        [FieldOffset(0)]
        public ushort LargePageCommit;
        [FieldOffset(0)]
        public ushort EntireUShortV;
        [FieldOffset(0)]
        public ushort EntireUShort;
    }
}