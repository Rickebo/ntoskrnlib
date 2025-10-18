using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _PNP_PROBLEM_CODE_LOG_ENTRY
{
    [FieldOffset(0)]
    public _LARGE_INTEGER Timestamp;
    [FieldOffset(8)]
    public IntPtr Operation;
    [FieldOffset(12)]
    public uint ProblemCode;
    [FieldOffset(16)]
    public int ProblemStatus;
}
