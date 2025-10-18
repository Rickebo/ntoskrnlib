using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=240)]
public struct _KSPECIAL_REGISTERS
{
    [FieldOffset(0)]
    public ulong Cr0;
    [FieldOffset(8)]
    public ulong Cr2;
    [FieldOffset(16)]
    public ulong Cr3;
    [FieldOffset(24)]
    public ulong Cr4;
    [FieldOffset(32)]
    public ulong KernelDr0;
    [FieldOffset(40)]
    public ulong KernelDr1;
    [FieldOffset(48)]
    public ulong KernelDr2;
    [FieldOffset(56)]
    public ulong KernelDr3;
    [FieldOffset(64)]
    public ulong KernelDr6;
    [FieldOffset(72)]
    public ulong KernelDr7;
    [FieldOffset(80)]
    public _KDESCRIPTOR Gdtr;
    [FieldOffset(96)]
    public _KDESCRIPTOR Idtr;
    [FieldOffset(112)]
    public ushort Tr;
    [FieldOffset(114)]
    public ushort Ldtr;
    [FieldOffset(116)]
    public uint MxCsr;
    [FieldOffset(120)]
    public ulong DebugControl;
    [FieldOffset(128)]
    public ulong LastBranchToRip;
    [FieldOffset(136)]
    public ulong LastBranchFromRip;
    [FieldOffset(144)]
    public ulong LastExceptionToRip;
    [FieldOffset(152)]
    public ulong LastExceptionFromRip;
    [FieldOffset(160)]
    public ulong Cr8;
    [FieldOffset(168)]
    public ulong MsrGsBase;
    [FieldOffset(176)]
    public ulong MsrGsSwap;
    [FieldOffset(184)]
    public ulong MsrStar;
    [FieldOffset(192)]
    public ulong MsrLStar;
    [FieldOffset(200)]
    public ulong MsrCStar;
    [FieldOffset(208)]
    public ulong MsrSyscallMask;
    [FieldOffset(216)]
    public ulong Xcr0;
    [FieldOffset(224)]
    public ulong MsrFsBase;
    [FieldOffset(232)]
    public ulong SpecialPadding0;
}
