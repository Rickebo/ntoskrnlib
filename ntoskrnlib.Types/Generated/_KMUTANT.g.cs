using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=56)]
public struct _KMUTANT
{
    [FieldOffset(0)]
    public _DISPATCHER_HEADER Header;
    [FieldOffset(24)]
    public _LIST_ENTRY MutantListEntry;
    [FieldOffset(40)]
    public IntPtr OwnerThread;
    [FieldOffset(48)]
    public byte MutantFlags;
    [FieldOffset(49)]
    public byte ApcDisable;
}
