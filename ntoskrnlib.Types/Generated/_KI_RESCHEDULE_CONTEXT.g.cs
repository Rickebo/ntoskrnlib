using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=240)]
public struct _KI_RESCHEDULE_CONTEXT
{
    [FieldOffset(0)]
    public byte ProcessorCount;
    [FieldOffset(1)]
    public byte ScanStart;
    [FieldOffset(4)]
    public IntPtr MaximumThreadIsolationWidth;
    [FieldOffset(8)]
    public IntPtr IsolationWidth;
    [FieldOffset(16)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public byte[] ProcessorEntries;
    [FieldOffset(176)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public byte[] SharedReadyLockQueues;
}
