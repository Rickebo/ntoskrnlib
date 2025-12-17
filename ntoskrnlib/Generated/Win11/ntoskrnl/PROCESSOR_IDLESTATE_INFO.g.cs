#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct PROCESSOR_IDLESTATE_INFO
    {
        [FieldOffset(0)]
        public uint TimeCheck;
        [FieldOffset(4)]
        public byte DemotePercent;
        [FieldOffset(5)]
        public byte PromotePercent;
        [FieldOffset(6)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] Spare;
    }
}