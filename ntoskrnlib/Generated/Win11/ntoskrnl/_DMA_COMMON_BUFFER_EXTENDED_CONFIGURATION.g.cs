#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _DMA_COMMON_BUFFER_EXTENDED_CONFIGURATION
    {
        [FieldOffset(0)]
        public uint ConfigType;
        [FieldOffset(8)]
        public _unnamed_tag_ LogicalAddressLimits;
        [FieldOffset(8)]
        public _unnamed_tag_ SubSection;
        [FieldOffset(8)]
        public uint HardwareAccessType;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ulong[] Reserved;
    }
}