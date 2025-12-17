#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _FACS
    {
        [FieldOffset(0)]
        public uint Signature;
        [FieldOffset(4)]
        public uint Length;
        [FieldOffset(8)]
        public uint HardwareSignature;
        [FieldOffset(12)]
        public uint pFirmwareWakingVector;
        [FieldOffset(16)]
        public uint GlobalLock;
        [FieldOffset(20)]
        public uint Flags;
        [FieldOffset(24)]
        public _LARGE_INTEGER x_FirmwareWakingVector;
        [FieldOffset(32)]
        public byte version;
        [FieldOffset(33)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 31)]
        public byte[] Reserved;
    }
}