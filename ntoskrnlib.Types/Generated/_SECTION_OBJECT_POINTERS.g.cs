using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _SECTION_OBJECT_POINTERS
{
    [FieldOffset(0)]
    public IntPtr DataSectionObject;
    [FieldOffset(8)]
    public IntPtr SharedCacheMap;
    [FieldOffset(16)]
    public IntPtr ImageSectionObject;
}
