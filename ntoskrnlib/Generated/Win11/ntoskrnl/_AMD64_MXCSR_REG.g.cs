#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _AMD64_MXCSR_REG
    {
        [FieldOffset(0)]
        public uint Value;
        [FieldOffset(0)]
        public uint IE;
        [FieldOffset(0)]
        public uint DE;
        [FieldOffset(0)]
        public uint ZE;
        [FieldOffset(0)]
        public uint OE;
        [FieldOffset(0)]
        public uint UE;
        [FieldOffset(0)]
        public uint PE;
        [FieldOffset(0)]
        public uint DAZ;
        [FieldOffset(0)]
        public uint IM;
        [FieldOffset(0)]
        public uint DM;
        [FieldOffset(0)]
        public uint ZM;
        [FieldOffset(0)]
        public uint OM;
        [FieldOffset(0)]
        public uint UM;
        [FieldOffset(0)]
        public uint PM;
        [FieldOffset(0)]
        public uint RC;
        [FieldOffset(0)]
        public uint FZ;
        [FieldOffset(0)]
        public uint res;
    }
}