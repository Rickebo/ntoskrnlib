#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _CM_KEY_HASH_TABLE_ENTRY
    {
        [FieldOffset(0)]
        public _EX_PUSH_LOCK Lock;
        [FieldOffset(8)]
        public IntPtr Owner;
        [FieldOffset(16)]
        public IntPtr Entry;
    }
}