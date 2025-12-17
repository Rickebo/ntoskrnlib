#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _DIRTY_PAGE_STATISTICS
    {
        [FieldOffset(0)]
        public ulong DirtyPages;
        [FieldOffset(8)]
        public ulong DirtyPagesLastScan;
        [FieldOffset(16)]
        public uint DirtyPagesScheduledLastScan;
    }
}