#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _DBGKD_SEARCH_MEMORY
    {
        [FieldOffset(0)]
        public ulong SearchAddress;
        [FieldOffset(0)]
        public ulong FoundAddress;
        [FieldOffset(8)]
        public ulong SearchLength;
        [FieldOffset(16)]
        public uint PatternLength;
    }
}