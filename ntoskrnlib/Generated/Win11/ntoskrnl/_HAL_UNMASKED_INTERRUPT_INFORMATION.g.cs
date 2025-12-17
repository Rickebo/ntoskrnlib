#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _HAL_UNMASKED_INTERRUPT_INFORMATION
    {
        [FieldOffset(0)]
        public ushort Version;
        [FieldOffset(2)]
        public ushort Size;
        [FieldOffset(4)]
        public _HAL_UNMASKED_INTERRUPT_FLAGS Flags;
        [FieldOffset(8)]
        public uint Mode;
        [FieldOffset(12)]
        public uint Polarity;
        [FieldOffset(16)]
        public uint Gsiv;
        [FieldOffset(20)]
        public ushort PinNumber;
        [FieldOffset(24)]
        public IntPtr DeviceHandle;
    }
}