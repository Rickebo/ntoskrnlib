using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _ALPC_PROCESS_CONTEXT
{
    [FieldOffset(0)]
    public _EX_PUSH_LOCK Lock;
    [FieldOffset(8)]
    public _LIST_ENTRY ViewListHead;
    [FieldOffset(24)]
    public ulong PagedPoolQuotaCache;
}
