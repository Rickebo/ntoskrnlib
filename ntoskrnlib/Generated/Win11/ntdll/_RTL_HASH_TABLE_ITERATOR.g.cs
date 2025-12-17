#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _RTL_HASH_TABLE_ITERATOR
    {
        [FieldOffset(0)]
        public IntPtr Hash;
        [FieldOffset(8)]
        public IntPtr HashEntry;
        [FieldOffset(16)]
        public IntPtr Bucket;
    }
}