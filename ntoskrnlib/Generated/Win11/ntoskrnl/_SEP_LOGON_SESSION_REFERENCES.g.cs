#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 200)]
    public partial struct _SEP_LOGON_SESSION_REFERENCES
    {
        [FieldOffset(0)]
        public IntPtr Next;
        [FieldOffset(8)]
        public _LUID LogonId;
        [FieldOffset(16)]
        public _LUID BuddyLogonId;
        [FieldOffset(24)]
        public _LUID ShadowBuddyLogonId;
        [FieldOffset(32)]
        public long ReferenceCount;
        [FieldOffset(40)]
        public uint Flags;
        [FieldOffset(48)]
        public IntPtr pDeviceMap;
        [FieldOffset(56)]
        public IntPtr Token;
        [FieldOffset(64)]
        public _UNICODE_STRING AccountName;
        [FieldOffset(80)]
        public _UNICODE_STRING AuthorityName;
        [FieldOffset(96)]
        public _SEP_CACHED_HANDLES_TABLE CachedHandlesTable;
        [FieldOffset(112)]
        public _EX_PUSH_LOCK SharedDataLock;
        [FieldOffset(120)]
        public IntPtr SharedClaimAttributes;
        [FieldOffset(128)]
        public IntPtr SharedSidValues;
        [FieldOffset(136)]
        public _OB_HANDLE_REVOCATION_BLOCK RevocationBlock;
        [FieldOffset(168)]
        public IntPtr ServerSilo;
        [FieldOffset(176)]
        public _LUID SiblingAuthId;
        [FieldOffset(184)]
        public _LIST_ENTRY TokenList;
    }
}