#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _KERNEL_STACK_SEGMENT
    {
        [FieldOffset(0)]
        public ulong StackBase;
        [FieldOffset(8)]
        public ulong StackLimit;
        [FieldOffset(16)]
        public ulong KernelStack;
        [FieldOffset(24)]
        public ulong InitialStack;
        [FieldOffset(32)]
        public ulong KernelShadowStackBase;
        [FieldOffset(40)]
        public _KERNEL_SHADOW_STACK_LIMIT KernelShadowStackLimit;
        [FieldOffset(48)]
        public ulong KernelShadowStack;
        [FieldOffset(56)]
        public ulong KernelShadowStackInitial;
    }
}