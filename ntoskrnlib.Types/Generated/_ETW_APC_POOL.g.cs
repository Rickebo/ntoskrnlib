using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=192)]
public struct _ETW_APC_POOL
{
    [FieldOffset(0)]
    public IntPtr LoggerContext;
    [FieldOffset(8)]
    public ulong ApcSpinLock;
    [FieldOffset(16)]
    public _SLIST_HEADER ApcGlobalListHead;
    [FieldOffset(32)]
    public _SLIST_HEADER ApcFreeListHead;
    [FieldOffset(48)]
    public IntPtr DpcContext1;
    [FieldOffset(56)]
    public IntPtr DpcContext2;
    [FieldOffset(64)]
    public IntPtr DpcContext3;
    [FieldOffset(72)]
    public IntPtr DpcNormalRoutine;
    [FieldOffset(80)]
    public IntPtr DpcCancelRoutine;
    [FieldOffset(88)]
    public IntPtr DpcThread;
    [FieldOffset(96)]
    public _KDPC Dpc;
    [FieldOffset(160)]
    public int Flags;
    [FieldOffset(164)]
    public int ApcCount;
    [FieldOffset(168)]
    public uint MinimumApcCount;
    [FieldOffset(172)]
    public uint MaximumApcCount;
    [FieldOffset(176)]
    public int OutstandingApcCount;
    [FieldOffset(180)]
    public int MaxOutstandingApcCount;
}
