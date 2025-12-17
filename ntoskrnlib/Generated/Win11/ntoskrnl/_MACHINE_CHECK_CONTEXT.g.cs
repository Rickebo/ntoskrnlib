#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _MACHINE_CHECK_CONTEXT
    {
        [FieldOffset(0)]
        public _MACHINE_FRAME MachineFrame;
        [FieldOffset(40)]
        public ulong Rax;
        [FieldOffset(48)]
        public ulong Rcx;
        [FieldOffset(56)]
        public ulong Rdx;
        [FieldOffset(64)]
        public ulong GsBase;
        [FieldOffset(72)]
        public ulong Cr3;
    }
}