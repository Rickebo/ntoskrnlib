#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public partial struct _MMPFNLIST
    {
        [FieldOffset(0)]
        public ulong Total;
        [FieldOffset(8)]
        public _MI_COLOR Color;
        [FieldOffset(12)]
        public uint ListName;
        [FieldOffset(16)]
        public ulong Flink;
        [FieldOffset(24)]
        public ulong Blink;
        [FieldOffset(32)]
        public int Lock;
        [FieldOffset(40)]
        public _MMPFN EmbeddedPfn;
    }
}