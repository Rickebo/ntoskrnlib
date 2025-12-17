#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _ETW_FILTER_EVENT_NAME_DATA
    {
        [FieldOffset(0)]
        public byte FilterIn;
        [FieldOffset(1)]
        public byte Level;
        [FieldOffset(8)]
        public ulong MatchAnyKeyword;
        [FieldOffset(16)]
        public ulong MatchAllKeyword;
        [FieldOffset(24)]
        public _RTL_HASH_TABLE NameTable;
    }
}