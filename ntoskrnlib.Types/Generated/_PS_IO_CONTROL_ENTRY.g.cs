using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=56)]
public struct _PS_IO_CONTROL_ENTRY
{
    [FieldOffset(0)]
    public _RTL_BALANCED_NODE VolumeTreeNode;
    [FieldOffset(0)]
    public _LIST_ENTRY FreeListEntry;
    [FieldOffset(16)]
    public ulong ReservedForParentValue;
    [FieldOffset(24)]
    public ulong VolumeKey;
    [FieldOffset(32)]
    public _EX_RUNDOWN_REF Rundown;
    [FieldOffset(40)]
    public IntPtr IoControl;
    [FieldOffset(48)]
    public IntPtr VolumeIoAttribution;
}
