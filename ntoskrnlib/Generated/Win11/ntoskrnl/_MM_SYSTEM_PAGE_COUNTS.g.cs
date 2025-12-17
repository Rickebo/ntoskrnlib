#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _MM_SYSTEM_PAGE_COUNTS
    {
        [FieldOffset(0)]
        public uint SystemCodePage;
        [FieldOffset(4)]
        public uint SystemDriverPage;
        [FieldOffset(8)]
        public int TotalSystemCodePages;
        [FieldOffset(12)]
        public int TotalSystemDriverPages;
    }
}