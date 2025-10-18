using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=4)]
public struct _MI_PFN_FLAGS5
{
    [FieldOffset(0)]
    public uint EntireField;
    [FieldOffset(0)]
    public _unnamed_tag_ StandbyList;
    [FieldOffset(0)]
    public _unnamed_tag_ MappedPageList;
    [FieldOffset(0)]
    public _unnamed_tag_ Active;
}
