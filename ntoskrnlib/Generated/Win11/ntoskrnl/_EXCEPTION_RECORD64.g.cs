#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 152)]
    public partial struct _EXCEPTION_RECORD64
    {
        [FieldOffset(0)]
        public int ExceptionCode;
        [FieldOffset(4)]
        public uint ExceptionFlags;
        [FieldOffset(8)]
        public ulong ExceptionRecord;
        [FieldOffset(16)]
        public ulong ExceptionAddress;
        [FieldOffset(24)]
        public uint NumberParameters;
        [FieldOffset(28)]
        public uint __unusedAlignment;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
        public ulong[] ExceptionInformation;
    }
}