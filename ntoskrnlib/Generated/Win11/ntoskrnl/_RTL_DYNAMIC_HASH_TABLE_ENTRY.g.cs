#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _RTL_DYNAMIC_HASH_TABLE_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Linkage;
        [FieldOffset(16)]
        public ulong Signature;
    }
}