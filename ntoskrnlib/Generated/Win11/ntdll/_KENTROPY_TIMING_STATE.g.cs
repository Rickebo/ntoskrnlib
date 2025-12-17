#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 344)]
    public partial struct _KENTROPY_TIMING_STATE
    {
        [FieldOffset(0)]
        public uint EntropyCount;
        [FieldOffset(4)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public uint[] Buffer;
        [FieldOffset(264)]
        public _KDPC Dpc;
        [FieldOffset(328)]
        public uint LastDeliveredBuffer;
        [FieldOffset(336)]
        public IntPtr ReservedRawDataBuffer;
    }
}