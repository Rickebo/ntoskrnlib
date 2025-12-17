#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MI_VAD_SEQUENTIAL_INFO
    {
        [FieldOffset(0)]
        public ulong Length;
        [FieldOffset(0)]
        public ulong Vpn;
        [FieldOffset(0)]
        public ulong MustBeZero;
        [FieldOffset(0)]
        public ulong EntireField;
    }
}