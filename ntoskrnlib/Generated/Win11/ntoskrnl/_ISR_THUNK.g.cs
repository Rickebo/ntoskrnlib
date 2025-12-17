#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _ISR_THUNK
    {
        [FieldOffset(0)]
        public byte PushImm;
        [FieldOffset(1)]
        public byte Vector;
        [FieldOffset(2)]
        public byte PushRbp;
        [FieldOffset(3)]
        public byte JmpOp;
        [FieldOffset(4)]
        public int JmpOffset;
    }
}