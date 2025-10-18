using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _WNF_SCOPE_MAP_ENTRY
{
    [FieldOffset(0)]
    public _WNF_LOCK MapEntryLock;
    [FieldOffset(8)]
    public _LIST_ENTRY MapEntryHead;
}
