#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial struct _IO_APIC_REGISTERS
    {
        [FieldOffset(0)]
        public uint RegisterIndex;
        [FieldOffset(4)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public uint[] Reserved1;
        [FieldOffset(16)]
        public uint RegisterValue;
        [FieldOffset(20)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
        public uint[] Reserved2;
        [FieldOffset(64)]
        public uint EndOfInterrupt;
    }
}