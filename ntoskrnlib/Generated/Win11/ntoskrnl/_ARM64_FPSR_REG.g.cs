#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _ARM64_FPSR_REG
    {
        [FieldOffset(0)]
        public uint Value;
        [FieldOffset(0)]
        public uint IOC;
        [FieldOffset(0)]
        public uint DZC;
        [FieldOffset(0)]
        public uint OFC;
        [FieldOffset(0)]
        public uint UFC;
        [FieldOffset(0)]
        public uint IXC;
        [FieldOffset(0)]
        public uint res0_1;
        [FieldOffset(0)]
        public uint IDC;
        [FieldOffset(0)]
        public uint res0_2;
        [FieldOffset(0)]
        public uint QC;
        [FieldOffset(0)]
        public uint V;
        [FieldOffset(0)]
        public uint C;
        [FieldOffset(0)]
        public uint Z;
        [FieldOffset(0)]
        public uint N;
    }
}