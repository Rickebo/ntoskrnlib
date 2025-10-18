using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=128)]
public struct _HANDLE_TABLE
{
    [FieldOffset(0)]
    public uint NextHandleNeedingPool;
    [FieldOffset(4)]
    public int ExtraInfoPages;
    [FieldOffset(8)]
    public ulong TableCode;
    [FieldOffset(16)]
    public IntPtr QuotaProcess;
    [FieldOffset(24)]
    public _LIST_ENTRY HandleTableList;
    [FieldOffset(40)]
    public uint UniqueProcessId;
    [FieldOffset(44)]
    public uint Flags;
    [FieldOffset(48)]
    public _EX_PUSH_LOCK HandleContentionEvent;
    [FieldOffset(56)]
    public _EX_PUSH_LOCK HandleTableLock;
    [FieldOffset(64)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=1)]
    public byte[] FreeLists;
    [FieldOffset(64)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=32)]
    public byte[] ActualEntry;
    [FieldOffset(96)]
    public IntPtr DebugInfo;
}
