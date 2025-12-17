#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _SECONDARY_INTERRUPT_PROVIDER_INTERFACE
    {
        [FieldOffset(0)]
        public ushort Size;
        [FieldOffset(2)]
        public ushort Version;
        [FieldOffset(8)]
        public IntPtr Context;
        [FieldOffset(16)]
        public uint GsivBase;
        [FieldOffset(20)]
        public ushort GsivSize;
        [FieldOffset(24)]
        public IntPtr DriverObject;
        [FieldOffset(32)]
        public IntPtr Reserved1;
        [FieldOffset(40)]
        public IntPtr Reserved2;
        [FieldOffset(48)]
        public IntPtr Reserved3;
        [FieldOffset(56)]
        public IntPtr Reserved4;
        [FieldOffset(64)]
        public IntPtr Reserved5;
        [FieldOffset(72)]
        public IntPtr Reserved6;
        [FieldOffset(80)]
        public IntPtr Reserved7;
    }
}