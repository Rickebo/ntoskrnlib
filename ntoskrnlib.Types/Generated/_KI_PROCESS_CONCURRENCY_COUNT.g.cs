using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=4)]
public struct _KI_PROCESS_CONCURRENCY_COUNT
{
    [FieldOffset(0)]
    public uint AllFields;
}
