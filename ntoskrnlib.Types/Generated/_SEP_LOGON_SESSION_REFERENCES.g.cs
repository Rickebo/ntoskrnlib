using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=192)]
public struct _SEP_LOGON_SESSION_REFERENCES
{
    [FieldOffset(0)]
    public IntPtr Next;
    [FieldOffset(8)]
    public _LUID LogonId;
    [FieldOffset(16)]
    public _LUID BuddyLogonId;
    [FieldOffset(24)]
    public long ReferenceCount;
    [FieldOffset(32)]
    public uint Flags;
    [FieldOffset(40)]
    public IntPtr pDeviceMap;
    [FieldOffset(48)]
    public IntPtr Token;
    [FieldOffset(56)]
    public _UNICODE_STRING AccountName;
    [FieldOffset(72)]
    public _UNICODE_STRING AuthorityName;
    [FieldOffset(88)]
    public _SEP_CACHED_HANDLES_TABLE CachedHandlesTable;
    [FieldOffset(104)]
    public _EX_PUSH_LOCK SharedDataLock;
    [FieldOffset(112)]
    public IntPtr SharedClaimAttributes;
    [FieldOffset(120)]
    public IntPtr SharedSidValues;
    [FieldOffset(128)]
    public _OB_HANDLE_REVOCATION_BLOCK RevocationBlock;
    [FieldOffset(160)]
    public IntPtr ServerSilo;
    [FieldOffset(168)]
    public _LUID SiblingAuthId;
    [FieldOffset(176)]
    public _LIST_ENTRY TokenList;
}
