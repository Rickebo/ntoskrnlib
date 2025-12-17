#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _CM_UOW_SET_VALUE_KEY_DATA
    {
        [FieldOffset(0)]
        public uint PreparedCell;
        [FieldOffset(4)]
        public uint OldValueCell;
        [FieldOffset(8)]
        public ushort NameLength;
        [FieldOffset(12)]
        public uint DataSize;
    }
}