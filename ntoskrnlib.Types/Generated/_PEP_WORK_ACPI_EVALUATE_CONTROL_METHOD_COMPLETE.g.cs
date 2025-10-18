using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=40)]
public struct _PEP_WORK_ACPI_EVALUATE_CONTROL_METHOD_COMPLETE
{
    [FieldOffset(0)]
    public IntPtr DeviceHandle;
    [FieldOffset(8)]
    public uint CompletionFlags;
    [FieldOffset(12)]
    public int MethodStatus;
    [FieldOffset(16)]
    public IntPtr CompletionContext;
    [FieldOffset(24)]
    public ulong OutputArgumentSize;
    [FieldOffset(32)]
    public IntPtr OutputArguments;
}
