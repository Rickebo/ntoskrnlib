using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _OB_HANDLE_REVOCATION_BLOCK
{
    [FieldOffset(0)]
    public _LIST_ENTRY RevocationInfos;
    [FieldOffset(16)]
    public _EX_PUSH_LOCK Lock;
    [FieldOffset(24)]
    public _EX_RUNDOWN_REF Rundown;
}
