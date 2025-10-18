using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=48)]
public struct _MMPFN
{
    [FieldOffset(0)]
    public _LIST_ENTRY ListEntry;
    [FieldOffset(0)]
    public _RTL_BALANCED_NODE TreeNode;
    [FieldOffset(0)]
    public _MIPFNFLINK u1;
    [FieldOffset(8)]
    public IntPtr PteAddress;
    [FieldOffset(8)]
    public ulong PteLong;
    [FieldOffset(16)]
    public _MMPTE OriginalPte;
    [FieldOffset(24)]
    public _MIPFNBLINK u2;
    [FieldOffset(32)]
    public _unnamed_tag_ u3;
    [FieldOffset(36)]
    public _MI_PFN_FLAGS5 u5;
    [FieldOffset(40)]
    public _MI_PFN_FLAGS4 u4;
}
