#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _KI_COOPERATIVE_IDLE_SEARCH_GENERATION_ID
    {
        [FieldOffset(0)]
        public ulong FullId;
        [FieldOffset(0)]
        public ulong Empty;
        [FieldOffset(0)]
        public ulong MinorId;
        [FieldOffset(0)]
        public ulong MajorId;
    }
}