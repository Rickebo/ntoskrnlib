using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=56)]
public struct _PEP_WORK_POWER_CONTROL
{
    [FieldOffset(0)]
    public IntPtr DeviceHandle;
    [FieldOffset(8)]
    public IntPtr PowerControlCode;
    [FieldOffset(16)]
    public IntPtr RequestContext;
    [FieldOffset(24)]
    public IntPtr InBuffer;
    [FieldOffset(32)]
    public ulong InBufferSize;
    [FieldOffset(40)]
    public IntPtr OutBuffer;
    [FieldOffset(48)]
    public ulong OutBufferSize;
}
