using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=224)]
public struct _POP_FX_ACCOUNTING
{
    [FieldOffset(0)]
    public ulong Lock;
    [FieldOffset(8)]
    public byte Active;
    [FieldOffset(12)]
    public uint DripsRequiredState;
    [FieldOffset(16)]
    public IntPtr AccountingMode;
    [FieldOffset(24)]
    public ulong ActiveStamp;
    [FieldOffset(32)]
    public _POP_FX_ACTIVE_TIME_ACCOUNTING CsActiveTimeAccounting;
    [FieldOffset(128)]
    public _POP_FX_ACTIVE_TIME_ACCOUNTING CsCriticalActiveTimeAccounting;
}
