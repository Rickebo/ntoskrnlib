using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=12)]
public struct _IMAGE_RUNTIME_FUNCTION_ENTRY
{
    [FieldOffset(0)]
    public uint BeginAddress;
    [FieldOffset(4)]
    public uint EndAddress;
    [FieldOffset(8)]
    public uint UnwindInfoAddress;
    [FieldOffset(8)]
    public uint UnwindData;
}
