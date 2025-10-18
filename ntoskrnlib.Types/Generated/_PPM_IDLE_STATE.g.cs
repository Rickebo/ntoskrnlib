using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=344)]
public struct _PPM_IDLE_STATE
{
    [FieldOffset(0)]
    public _KAFFINITY_EX DomainMembers;
    [FieldOffset(264)]
    public _UNICODE_STRING Name;
    [FieldOffset(280)]
    public uint Latency;
    [FieldOffset(284)]
    public uint BreakEvenDuration;
    [FieldOffset(288)]
    public uint Power;
    [FieldOffset(292)]
    public uint StateFlags;
    [FieldOffset(296)]
    public _PPM_VETO_ACCOUNTING VetoAccounting;
    [FieldOffset(336)]
    public byte StateType;
    [FieldOffset(337)]
    public byte InterruptsEnabled;
    [FieldOffset(338)]
    public byte Interruptible;
    [FieldOffset(339)]
    public byte ContextRetained;
    [FieldOffset(340)]
    public byte CacheCoherent;
    [FieldOffset(341)]
    public byte WakesSpuriously;
    [FieldOffset(342)]
    public byte PlatformOnly;
    [FieldOffset(343)]
    public byte NoCState;
}
