#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial struct _DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT
    {
        [FieldOffset(0)]
        public uint Size;
        [FieldOffset(4)]
        public uint Action;
        [FieldOffset(8)]
        public uint Flags;
        [FieldOffset(12)]
        public uint OperationStatus;
        [FieldOffset(16)]
        public uint ExtendedError;
        [FieldOffset(20)]
        public uint TargetDetailedError;
        [FieldOffset(24)]
        public uint ReservedStatus;
        [FieldOffset(28)]
        public uint OutputBlockOffset;
        [FieldOffset(32)]
        public uint OutputBlockLength;
    }
}