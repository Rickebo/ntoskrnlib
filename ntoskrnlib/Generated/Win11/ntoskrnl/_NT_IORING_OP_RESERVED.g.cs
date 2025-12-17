#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _NT_IORING_OP_RESERVED
    {
        [FieldOffset(0)]
        public ulong Argument1;
        [FieldOffset(8)]
        public ulong Argument2;
        [FieldOffset(16)]
        public ulong Argument3;
        [FieldOffset(24)]
        public ulong Argument4;
        [FieldOffset(32)]
        public ulong Argument5;
        [FieldOffset(40)]
        public ulong Argument6;
    }
}