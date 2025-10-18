using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=136)]
public struct _DYNAMIC_FUNCTION_TABLE
{
    [FieldOffset(0)]
    public _LIST_ENTRY ListEntry;
    [FieldOffset(16)]
    public IntPtr FunctionTable;
    [FieldOffset(24)]
    public _LARGE_INTEGER TimeStamp;
    [FieldOffset(32)]
    public ulong MinimumAddress;
    [FieldOffset(40)]
    public ulong MaximumAddress;
    [FieldOffset(48)]
    public ulong BaseAddress;
    [FieldOffset(56)]
    public IntPtr Callback;
    [FieldOffset(64)]
    public IntPtr Context;
    [FieldOffset(72)]
    public IntPtr OutOfProcessCallbackDll;
    [FieldOffset(80)]
    public IntPtr Type;
    [FieldOffset(84)]
    public uint EntryCount;
    [FieldOffset(88)]
    public _RTL_BALANCED_NODE TreeNodeMin;
    [FieldOffset(112)]
    public _RTL_BALANCED_NODE TreeNodeMax;
}
