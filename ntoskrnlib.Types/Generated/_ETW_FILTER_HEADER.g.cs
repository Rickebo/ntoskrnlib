using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=104)]
public struct _ETW_FILTER_HEADER
{
    [FieldOffset(0)]
    public int FilterFlags;
    [FieldOffset(8)]
    public IntPtr PidFilter;
    [FieldOffset(16)]
    public IntPtr ExeFilter;
    [FieldOffset(24)]
    public IntPtr PkgIdFilter;
    [FieldOffset(32)]
    public IntPtr PkgAppIdFilter;
    [FieldOffset(40)]
    public IntPtr ContainerFilter;
    [FieldOffset(48)]
    public IntPtr StackWalkIdFilter;
    [FieldOffset(56)]
    public IntPtr StackWalkNameFilter;
    [FieldOffset(64)]
    public IntPtr StackWalkLevelKwFilter;
    [FieldOffset(72)]
    public IntPtr EventIdFilter;
    [FieldOffset(80)]
    public IntPtr PayloadFilter;
    [FieldOffset(88)]
    public IntPtr ProviderSideFilter;
    [FieldOffset(96)]
    public IntPtr EventNameFilter;
}
