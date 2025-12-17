#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _ETW_HASH_BUCKET
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public _LIST_ENTRY[] ListHead;
        [FieldOffset(48)]
        public _EX_PUSH_LOCK BucketLock;
    }
}