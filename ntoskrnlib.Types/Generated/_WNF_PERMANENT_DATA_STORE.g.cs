using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=48)]
public struct _WNF_PERMANENT_DATA_STORE
{
    [FieldOffset(0)]
    public _WNF_NODE_HEADER Header;
    [FieldOffset(8)]
    public _WNF_LOCK Lock;
    [FieldOffset(16)]
    public IntPtr Handle;
    [FieldOffset(24)]
    public _LIST_ENTRY Links;
    [FieldOffset(40)]
    public IntPtr DataScopeType;
    [FieldOffset(44)]
    public uint ScopeInstanceIdSize;
}
