using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=32)]
public struct _ETW_PRIV_HANDLE_DEMUX_TABLE
{
    [FieldOffset(0)]
    public _RTL_RB_TREE Tree;
    [FieldOffset(16)]
    public _EX_PUSH_LOCK Lock;
    [FieldOffset(24)]
    public ushort SequenceNumber;
}
