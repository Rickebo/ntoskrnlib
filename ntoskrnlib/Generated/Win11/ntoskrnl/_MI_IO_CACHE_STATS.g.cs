#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct _MI_IO_CACHE_STATS
    {
        [FieldOffset(0)]
        public uint UnmappedCacheFlush;
        [FieldOffset(4)]
        public uint UnmappedCacheConflict;
        [FieldOffset(8)]
        public uint PermanentIoAttributeConflict;
        [FieldOffset(12)]
        public uint PermanentIoNodeConflict;
        [FieldOffset(16)]
        public uint ExclusionReferenceConflict;
    }
}