using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=372)]
public struct _ETW_SYSTEM_LOGGER_SETTINGS
{
    [FieldOffset(0)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=8)]
    public byte[] EtwpSystemLogger;
    [FieldOffset(16)]
    public uint EtwpActiveSystemLoggers;
    [FieldOffset(20)]
    public _PERFINFO_GROUPMASK SiloGlobalGroupMask;
    [FieldOffset(52)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=10)]
    public byte[] EtwpGroupMasks;
}
