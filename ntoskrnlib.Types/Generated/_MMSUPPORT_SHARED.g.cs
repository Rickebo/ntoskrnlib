using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=128)]
public struct _MMSUPPORT_SHARED
{
    [FieldOffset(0)]
    public IntPtr WorkingSetLockArray;
    [FieldOffset(8)]
    public ulong ReleasedCommitDebt;
    [FieldOffset(16)]
    public ulong ResetPagesRepurposedCount;
    [FieldOffset(24)]
    public IntPtr WsSwapSupport;
    [FieldOffset(32)]
    public IntPtr CommitReleaseContext;
    [FieldOffset(40)]
    public IntPtr AccessLog;
    [FieldOffset(48)]
    public ulong ChargedWslePages;
    [FieldOffset(56)]
    public ulong ActualWslePages;
    [FieldOffset(64)]
    public int WorkingSetCoreLock;
    [FieldOffset(72)]
    public IntPtr ShadowMapping;
}
