#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct _ETW_SYSTEM_LOGGER
    {
        [FieldOffset(0)]
        public byte LoggerId;
        [FieldOffset(1)]
        public byte ClockType;
    }
}