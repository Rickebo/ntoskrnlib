#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _EVENT_FILTER_LEVEL_KW
    {
        [FieldOffset(0)]
        public ulong MatchAnyKeyword;
        [FieldOffset(8)]
        public ulong MatchAllKeyword;
        [FieldOffset(16)]
        public byte Level;
        [FieldOffset(17)]
        public byte FilterIn;
    }
}