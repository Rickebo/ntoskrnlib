using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _KQOS_GROUPING_SETS
{
    [FieldOffset(0)]
    public ulong SingleCoreSet;
    [FieldOffset(8)]
    public ulong SmtSet;
}
