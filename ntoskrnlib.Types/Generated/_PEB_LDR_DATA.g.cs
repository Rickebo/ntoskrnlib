using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=88)]
public struct _PEB_LDR_DATA
{
    [FieldOffset(0)]
    public uint Length;
    [FieldOffset(4)]
    public byte Initialized;
    [FieldOffset(8)]
    public IntPtr SsHandle;
    [FieldOffset(16)]
    public _LIST_ENTRY InLoadOrderModuleList;
    [FieldOffset(32)]
    public _LIST_ENTRY InMemoryOrderModuleList;
    [FieldOffset(48)]
    public _LIST_ENTRY InInitializationOrderModuleList;
    [FieldOffset(64)]
    public IntPtr EntryInProgress;
    [FieldOffset(72)]
    public byte ShutdownInProgress;
    [FieldOffset(80)]
    public IntPtr ShutdownThreadId;
}
