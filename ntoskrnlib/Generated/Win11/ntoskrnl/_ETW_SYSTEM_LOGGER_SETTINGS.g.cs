#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 372)]
    public partial struct _ETW_SYSTEM_LOGGER_SETTINGS
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public _ETW_SYSTEM_LOGGER[] EtwpSystemLogger;
        [FieldOffset(16)]
        public uint EtwpActiveSystemLoggers;
        [FieldOffset(20)]
        public _PERFINFO_GROUPMASK SiloGlobalGroupMask;
        [FieldOffset(52)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public _PERFINFO_GROUPMASK[] EtwpGroupMasks;
    }
}