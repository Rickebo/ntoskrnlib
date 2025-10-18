using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=16)]
public struct _PS_DYNAMIC_ENFORCED_ADDRESS_RANGES
{
    [FieldOffset(0)]
    public _RTL_AVL_TREE Tree;
    [FieldOffset(8)]
    public _EX_PUSH_LOCK Lock;
}
