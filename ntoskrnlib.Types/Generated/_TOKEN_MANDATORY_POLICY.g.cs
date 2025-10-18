using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=4)]
public struct _TOKEN_MANDATORY_POLICY
{
    [FieldOffset(0)]
    public uint Policy;
}
