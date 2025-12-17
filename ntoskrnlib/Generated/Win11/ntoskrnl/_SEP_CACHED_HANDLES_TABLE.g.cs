#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _SEP_CACHED_HANDLES_TABLE
    {
        [FieldOffset(0)]
        public _EX_PUSH_LOCK Lock;
        [FieldOffset(8)]
        public IntPtr HashTable;
    }
}