using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=56)]
public struct _WNF_SILODRIVERSTATE
{
    [FieldOffset(0)]
    public IntPtr ScopeMap;
    [FieldOffset(8)]
    public IntPtr PermanentNameStoreRootKey;
    [FieldOffset(16)]
    public IntPtr PersistentNameStoreRootKey;
    [FieldOffset(24)]
    public long PermanentNameSequenceNumber;
    [FieldOffset(32)]
    public _WNF_LOCK PermanentNameSequenceNumberLock;
    [FieldOffset(40)]
    public long PermanentNameSequenceNumberPool;
    [FieldOffset(48)]
    public long RuntimeNameSequenceNumber;
}
