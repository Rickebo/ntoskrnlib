using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=8)]
public struct _KERNEL_SHADOW_STACK_LIMIT
{
    [FieldOffset(0)]
    public ulong AllFields;
}
