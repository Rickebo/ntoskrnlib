#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _SK_CRASH_MODULE
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public short[] ImageName;
        [FieldOffset(64)]
        public uint SizeOfImage;
        [FieldOffset(68)]
        public uint TimeDateStamp;
    }
}