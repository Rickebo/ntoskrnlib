#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _CPU_INFO
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] AsUINT32;
        [FieldOffset(0)]
        public uint Eax;
        [FieldOffset(4)]
        public uint Ebx;
        [FieldOffset(8)]
        public uint Ecx;
        [FieldOffset(12)]
        public uint Edx;
    }
}