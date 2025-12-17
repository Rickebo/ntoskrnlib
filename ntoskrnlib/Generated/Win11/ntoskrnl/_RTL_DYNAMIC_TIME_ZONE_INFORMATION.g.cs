#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 432)]
    public partial struct _RTL_DYNAMIC_TIME_ZONE_INFORMATION
    {
        [FieldOffset(0)]
        public _RTL_TIME_ZONE_INFORMATION tzi;
        [FieldOffset(172)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public short[] TimeZoneKeyName;
        [FieldOffset(428)]
        public byte DynamicDaylightTimeDisabled;
    }
}