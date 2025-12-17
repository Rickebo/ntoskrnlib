#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _MI_WRITE_CALIBRATION
    {
        [FieldOffset(0)]
        public uint MaximumNumberProcessors;
        [FieldOffset(4)]
        public byte OptimalWriteType;
        [FieldOffset(5)]
        public byte CalibrationCompleted;
        [FieldOffset(6)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] CalibrationFinal;
        [FieldOffset(8)]
        public ulong PerProcessorNumberOfBytes;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] PerProcessorBandwidth;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] OptimalWriteProcessors;
        [FieldOffset(48)]
        public IntPtr PureZeroing;
    }
}