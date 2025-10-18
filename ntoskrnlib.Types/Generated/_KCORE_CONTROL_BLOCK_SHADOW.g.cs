using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=64)]
public struct _KCORE_CONTROL_BLOCK_SHADOW
{
    [FieldOffset(0)]
    public ulong Lock;
    [FieldOffset(8)]
    public ulong CurrentIsolationDomain;
    [FieldOffset(16)]
    public ulong NextIsolationDomain;
    [FieldOffset(24)]
    public byte TotalProcessors;
    [FieldOffset(25)]
    public byte IdleProcessors;
    [FieldOffset(26)]
    public byte NewDomainProcessors;
    [FieldOffset(27)]
    public byte Spare;
    [FieldOffset(28)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public byte[] ProcessorStates;
    [FieldOffset(32)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public ulong[] InterruptTargets;
}
