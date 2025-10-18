using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=120)]
public struct _FS_FILTER_CALLBACKS
{
    [FieldOffset(0)]
    public uint SizeOfFsFilterCallbacks;
    [FieldOffset(4)]
    public uint Reserved;
    [FieldOffset(8)]
    public IntPtr PreAcquireForSectionSynchronization;
    [FieldOffset(16)]
    public IntPtr PostAcquireForSectionSynchronization;
    [FieldOffset(24)]
    public IntPtr PreReleaseForSectionSynchronization;
    [FieldOffset(32)]
    public IntPtr PostReleaseForSectionSynchronization;
    [FieldOffset(40)]
    public IntPtr PreAcquireForCcFlush;
    [FieldOffset(48)]
    public IntPtr PostAcquireForCcFlush;
    [FieldOffset(56)]
    public IntPtr PreReleaseForCcFlush;
    [FieldOffset(64)]
    public IntPtr PostReleaseForCcFlush;
    [FieldOffset(72)]
    public IntPtr PreAcquireForModifiedPageWriter;
    [FieldOffset(80)]
    public IntPtr PostAcquireForModifiedPageWriter;
    [FieldOffset(88)]
    public IntPtr PreReleaseForModifiedPageWriter;
    [FieldOffset(96)]
    public IntPtr PostReleaseForModifiedPageWriter;
    [FieldOffset(104)]
    public IntPtr PreQueryOpen;
    [FieldOffset(112)]
    public IntPtr PostQueryOpen;
}
