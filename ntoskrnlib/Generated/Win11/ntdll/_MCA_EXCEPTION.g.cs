#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 256)]
    public partial struct _MCA_EXCEPTION
    {
        [FieldOffset(0)]
        public uint VersionNumber;
        [FieldOffset(4)]
        public uint ExceptionType;
        [FieldOffset(8)]
        public _LARGE_INTEGER TimeStamp;
        [FieldOffset(16)]
        public uint ProcessorNumber;
        [FieldOffset(20)]
        public uint Reserved1;
        [FieldOffset(24)]
        public _unnamed_tag_ u;
        [FieldOffset(56)]
        public uint ExtCnt;
        [FieldOffset(60)]
        public uint Reserved3;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public ulong[] ExtReg;
    }
}