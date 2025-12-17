#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct DEBUG_DEVICE_ADDRESS
    {
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(1)]
        public byte Valid;
        [FieldOffset(2)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] Reserved;
        [FieldOffset(2)]
        public byte BitWidth;
        [FieldOffset(3)]
        public byte AccessSize;
        [FieldOffset(8)]
        public IntPtr TranslatedAddress;
        [FieldOffset(16)]
        public uint Length;
    }
}