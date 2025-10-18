using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=304)]
public struct _POP_FX_WORK_POOL
{
    [FieldOffset(0)]
    public IntPtr Plugin;
    [FieldOffset(8)]
    public ulong EmergencyWorkQueueLock;
    [FieldOffset(16)]
    public _LIST_ENTRY EmergencyWorkQueue;
    [FieldOffset(32)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public byte[] WorkPoolQueues;
    [FieldOffset(96)]
    public int WorkItemStatus;
    [FieldOffset(104)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public byte[] WorkItems;
    [FieldOffset(264)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=5)]
    public byte[] PoolWorkerThreads;
}
