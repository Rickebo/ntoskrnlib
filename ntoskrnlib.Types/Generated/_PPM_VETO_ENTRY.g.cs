using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=64)]
public struct _PPM_VETO_ENTRY
{
    [FieldOffset(0)]
    public _LIST_ENTRY Link;
    [FieldOffset(16)]
    public uint VetoReason;
    [FieldOffset(20)]
    public uint ReferenceCount;
    [FieldOffset(24)]
    public ulong HitCount;
    [FieldOffset(32)]
    public ulong LastActivationTime;
    [FieldOffset(40)]
    public ulong TotalActiveTime;
    [FieldOffset(48)]
    public ulong CsActivationTime;
    [FieldOffset(56)]
    public ulong CsActiveTime;
}
