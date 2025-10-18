using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=40)]
public struct _PPM_VETO_ACCOUNTING
{
    [FieldOffset(0)]
    public int VetoPresent;
    [FieldOffset(8)]
    public _LIST_ENTRY VetoListHead;
    [FieldOffset(24)]
    public byte CsAccountingBlocks;
    [FieldOffset(25)]
    public byte BlocksDrips;
    [FieldOffset(28)]
    public uint PreallocatedVetoCount;
    [FieldOffset(32)]
    public IntPtr PreallocatedVetoList;
}
