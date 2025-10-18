using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=424)]
public struct _POP_FX_PLUGIN
{
    [FieldOffset(0)]
    public _LIST_ENTRY Link;
    [FieldOffset(16)]
    public uint Version;
    [FieldOffset(24)]
    public ulong Flags;
    [FieldOffset(32)]
    public _KQUEUE WorkQueue;
    [FieldOffset(96)]
    public IntPtr AcceptDeviceNotification;
    [FieldOffset(104)]
    public IntPtr AcceptProcessorNotification;
    [FieldOffset(112)]
    public IntPtr AcceptAcpiNotification;
    [FieldOffset(120)]
    public _POP_FX_WORK_POOL PluginWorkPool;
}
