#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _WRITE_BEHIND_THROUGHPUT
    {
        [FieldOffset(0)]
        public uint PagesYetToWrite;
        [FieldOffset(4)]
        public uint Throughput;
    }
}