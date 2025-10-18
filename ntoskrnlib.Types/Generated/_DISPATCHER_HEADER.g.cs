using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _DISPATCHER_HEADER
{
    [FieldOffset(0)]
    public int Lock;
    [FieldOffset(0)]
    public int LockNV;
    [FieldOffset(0)]
    public byte Type;
    [FieldOffset(1)]
    public byte Signalling;
    [FieldOffset(2)]
    public byte Size;
    [FieldOffset(3)]
    public byte Reserved1;
    [FieldOffset(0)]
    public byte TimerType;
    [FieldOffset(1)]
    public byte TimerControlFlags;
    [FieldOffset(2)]
    public byte Hand;
    [FieldOffset(3)]
    public byte TimerMiscFlags;
    [FieldOffset(0)]
    public byte Timer2Type;
    [FieldOffset(1)]
    public byte Timer2Flags;
    [FieldOffset(2)]
    public byte Timer2ComponentId;
    [FieldOffset(3)]
    public byte Timer2RelativeId;
    [FieldOffset(0)]
    public byte QueueType;
    [FieldOffset(1)]
    public byte QueueControlFlags;
    [FieldOffset(2)]
    public byte QueueSize;
    [FieldOffset(3)]
    public byte QueueReserved;
    [FieldOffset(0)]
    public byte ThreadType;
    [FieldOffset(1)]
    public byte ThreadReserved;
    [FieldOffset(2)]
    public byte ThreadControlFlags;
    [FieldOffset(3)]
    public byte DebugActive;
    [FieldOffset(0)]
    public byte MutantType;
    [FieldOffset(1)]
    public byte MutantSize;
    [FieldOffset(2)]
    public byte DpcActive;
    [FieldOffset(3)]
    public byte MutantReserved;
    [FieldOffset(4)]
    public int SignalState;
    [FieldOffset(8)]
    public _LIST_ENTRY WaitListHead;
}
