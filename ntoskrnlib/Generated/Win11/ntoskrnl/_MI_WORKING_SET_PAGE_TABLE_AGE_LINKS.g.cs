#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _MI_WORKING_SET_PAGE_TABLE_AGE_LINKS
    {
        [FieldOffset(0)]
        public int Lock;
        [FieldOffset(4)]
        public uint EntryCount;
        [FieldOffset(8)]
        public IntPtr Flink;
        [FieldOffset(16)]
        public IntPtr Blink;
    }
}