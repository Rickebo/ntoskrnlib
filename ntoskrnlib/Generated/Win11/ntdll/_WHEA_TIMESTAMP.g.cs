#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _WHEA_TIMESTAMP
    {
        [FieldOffset(0)]
        public ulong Seconds;
        [FieldOffset(0)]
        public ulong Minutes;
        [FieldOffset(0)]
        public ulong Hours;
        [FieldOffset(0)]
        public ulong Precise;
        [FieldOffset(0)]
        public ulong Reserved;
        [FieldOffset(0)]
        public ulong Day;
        [FieldOffset(0)]
        public ulong Month;
        [FieldOffset(0)]
        public ulong Year;
        [FieldOffset(0)]
        public ulong Century;
        [FieldOffset(0)]
        public _LARGE_INTEGER AsLARGE_INTEGER;
    }
}