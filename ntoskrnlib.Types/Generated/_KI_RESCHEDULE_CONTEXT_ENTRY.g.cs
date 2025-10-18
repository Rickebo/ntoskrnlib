using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=40)]
public struct _KI_RESCHEDULE_CONTEXT_ENTRY
{
    [FieldOffset(0)]
    public IntPtr Prcb;
    [FieldOffset(8)]
    public IntPtr SharedReadyQueue;
    [FieldOffset(16)]
    public IntPtr CompareThread;
    [FieldOffset(24)]
    public IntPtr NewThread;
    [FieldOffset(32)]
    public byte AllCompareThreadStateFlags;
    [FieldOffset(33)]
    public byte AllNewThreadStateFlags;
    [FieldOffset(34)]
    public byte AllCommitFlags;
    [FieldOffset(35)]
    public byte AllCompletionFlags;
    [FieldOffset(36)]
    public sbyte KickPriority;
    [FieldOffset(37)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=3)]
    public byte[] Spare;
}
