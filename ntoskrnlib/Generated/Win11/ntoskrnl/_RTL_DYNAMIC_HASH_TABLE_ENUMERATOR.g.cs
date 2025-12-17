#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _RTL_DYNAMIC_HASH_TABLE_ENUMERATOR
    {
        [FieldOffset(0)]
        public _RTL_DYNAMIC_HASH_TABLE_ENTRY HashEntry;
        [FieldOffset(0)]
        public IntPtr CurEntry;
        [FieldOffset(24)]
        public IntPtr ChainHead;
        [FieldOffset(32)]
        public uint BucketIndex;
    }
}