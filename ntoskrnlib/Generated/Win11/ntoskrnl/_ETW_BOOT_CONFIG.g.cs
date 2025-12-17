#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _ETW_BOOT_CONFIG
    {
        [FieldOffset(0)]
        public uint MaxLoggers;
        [FieldOffset(8)]
        public _LIST_ENTRY BootLoggersList;
    }
}