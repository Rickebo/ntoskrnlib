#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct SYSTEM_POWER_LEVEL
    {
        [FieldOffset(0)]
        public byte Enable;
        [FieldOffset(1)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Spare;
        [FieldOffset(4)]
        public uint BatteryLevel;
        [FieldOffset(8)]
        public POWER_ACTION_POLICY PowerPolicy;
        [FieldOffset(20)]
        public uint MinSystemState;
    }
}