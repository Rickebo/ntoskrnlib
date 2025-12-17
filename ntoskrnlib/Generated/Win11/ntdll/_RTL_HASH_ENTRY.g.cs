#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _RTL_HASH_ENTRY
    {
        [FieldOffset(0)]
        public _SINGLE_LIST_ENTRY BucketLink;
        [FieldOffset(8)]
        public ulong Key;
    }
}