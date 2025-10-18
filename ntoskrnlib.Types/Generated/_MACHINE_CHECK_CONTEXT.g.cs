using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=80)]
public struct _MACHINE_CHECK_CONTEXT
{
    [FieldOffset(0)]
    public _MACHINE_FRAME MachineFrame;
    [FieldOffset(40)]
    public ulong Rax;
    [FieldOffset(48)]
    public ulong Rcx;
    [FieldOffset(56)]
    public ulong Rdx;
    [FieldOffset(64)]
    public ulong GsBase;
    [FieldOffset(72)]
    public ulong Cr3;
}
