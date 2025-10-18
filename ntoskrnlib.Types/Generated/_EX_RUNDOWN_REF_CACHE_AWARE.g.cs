using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=24)]
public struct _EX_RUNDOWN_REF_CACHE_AWARE
{
    [FieldOffset(0)]
    public IntPtr RunRefs;
    [FieldOffset(8)]
    public IntPtr PoolToFree;
    [FieldOffset(16)]
    public uint RunRefSize;
    [FieldOffset(20)]
    public uint Number;
}
