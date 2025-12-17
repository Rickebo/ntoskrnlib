#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _OSLOADER_PAGE_TABLE_LOG
    {
        [FieldOffset(0)]
        public IntPtr LegacyPte;
        [FieldOffset(8)]
        public ulong Pfn;
        [FieldOffset(16)]
        public uint MemoryType;
        [FieldOffset(24)]
        public ulong BasePage;
        [FieldOffset(32)]
        public ulong PageCount;
    }
}