using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _PEP_WORK_COMPLETE_PERF_STATE
{
    [FieldOffset(0)]
    public IntPtr DeviceHandle;
    [FieldOffset(8)]
    public uint Component;
    [FieldOffset(12)]
    public byte Succeeded;
}
