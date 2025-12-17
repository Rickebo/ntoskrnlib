#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _EXCEPTION_RECORD32
    {
        [FieldOffset(0)]
        public int ExceptionCode;
        [FieldOffset(4)]
        public uint ExceptionFlags;
        [FieldOffset(8)]
        public uint ExceptionRecord;
        [FieldOffset(12)]
        public uint ExceptionAddress;
        [FieldOffset(16)]
        public uint NumberParameters;
        [FieldOffset(20)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public uint[] ExceptionInformation;
    }
}