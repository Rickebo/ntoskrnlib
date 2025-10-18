using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=40)]
public struct _ETW_IPT_SUPPORT
{
    [FieldOffset(0)]
    public IntPtr IptHandle;
    [FieldOffset(8)]
    public ulong IptOption;
    [FieldOffset(16)]
    public IntPtr EtwHwTraceExtInterface;
    [FieldOffset(24)]
    public uint HookIdCount;
    [FieldOffset(28)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public ushort[] HookId;
}
