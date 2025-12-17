#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _KSTACK_CONTROL
    {
        [FieldOffset(0)]
        public ulong StackBase;
        [FieldOffset(8)]
        public ulong ActualLimit;
        [FieldOffset(8)]
        public ulong StackExpansion;
        [FieldOffset(16)]
        public _KERNEL_STACK_SEGMENT Previous;
    }
}