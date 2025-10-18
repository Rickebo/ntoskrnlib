using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _KAB_UM_PROCESS_TREE
{
    [FieldOffset(0)]
    public _RTL_RB_TREE Tree;
    [FieldOffset(16)]
    public ulong TreeLock;
}
