using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=56)]
public struct _ETW_HASH_BUCKET
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
    public byte[] ListHead;
    [FieldOffset(48)]
    public _EX_PUSH_LOCK BucketLock;
}
