using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=48)]
public struct _KAPC_STATE
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=2)]
    public byte[] ApcListHead;
    [FieldOffset(32)]
    public IntPtr Process;
    [FieldOffset(40)]
    public byte InProgressFlags;
    [FieldOffset(41)]
    public byte KernelApcPending;
    [FieldOffset(42)]
    public byte UserApcPendingAll;
}
