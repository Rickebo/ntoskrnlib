using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _MI_ACTIVE_PFN
{
    [FieldOffset(0)]
    public _unnamed_tag_ Leaf;
    [FieldOffset(0)]
    public _unnamed_tag_ PageTable;
    [FieldOffset(0)]
    public ulong EntireActiveField;
}
