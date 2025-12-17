#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _PROC_IDLE_STATE_BUCKET
    {
        [FieldOffset(0)]
        public ulong TotalTime;
        [FieldOffset(8)]
        public ulong MinTime;
        [FieldOffset(16)]
        public ulong MaxTime;
        [FieldOffset(24)]
        public uint Count;
    }
}