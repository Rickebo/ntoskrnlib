using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=4)]
public struct _WNF_NODE_HEADER
{
    [FieldOffset(0)]
    public ushort NodeTypeCode;
    [FieldOffset(2)]
    public ushort NodeByteSize;
}
