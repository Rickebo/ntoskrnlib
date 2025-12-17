#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _ARM64_FPCR_REG
    {
        [FieldOffset(0)]
        public uint Value;
        [FieldOffset(0)]
        public uint res0_1;
        [FieldOffset(0)]
        public uint IOE;
        [FieldOffset(0)]
        public uint DZE;
        [FieldOffset(0)]
        public uint OFE;
        [FieldOffset(0)]
        public uint UFE;
        [FieldOffset(0)]
        public uint IXE;
        [FieldOffset(0)]
        public uint res0_2;
        [FieldOffset(0)]
        public uint IDE;
        [FieldOffset(0)]
        public uint Len;
        [FieldOffset(0)]
        public uint FZ16;
        [FieldOffset(0)]
        public uint Stride;
        [FieldOffset(0)]
        public uint RMode;
        [FieldOffset(0)]
        public uint FZ;
        [FieldOffset(0)]
        public uint DN;
        [FieldOffset(0)]
        public uint AHP;
        [FieldOffset(0)]
        public uint res0_3;
    }
}