#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MIPFNFLINK
    {
        [FieldOffset(0)]
        public IntPtr NextSlistPfn;
        [FieldOffset(0)]
        public IntPtr Next;
        [FieldOffset(0)]
        public ulong Flink;
        [FieldOffset(0)]
        public ulong NodeFlinkLow;
        [FieldOffset(0)]
        public ulong EntireField;
        [FieldOffset(0)]
        public _MI_ACTIVE_PFN Active;
    }
}