#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _KERNEL_SHADOW_STACK_LIMIT
    {
        [FieldOffset(0)]
        public ulong AllFields;
        [FieldOffset(0)]
        public ulong ShadowStackType;
        [FieldOffset(0)]
        public ulong Unused;
        [FieldOffset(0)]
        public ulong ShadowStackLimitPfn;
    }
}