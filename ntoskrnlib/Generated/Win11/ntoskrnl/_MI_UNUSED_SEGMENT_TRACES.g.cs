#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _MI_UNUSED_SEGMENT_TRACES
    {
        [FieldOffset(0)]
        public ulong ElapsedTime;
        [FieldOffset(8)]
        public ulong PagesMoved;
        [FieldOffset(16)]
        public ulong PagesFlushed;
        [FieldOffset(24)]
        public uint NumberOfThreads;
    }
}