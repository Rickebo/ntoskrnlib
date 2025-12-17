#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _CM_INDEX_HINT_BLOCK
    {
        [FieldOffset(0)]
        public uint Count;
        [FieldOffset(4)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public uint[] HashKey;
    }
}