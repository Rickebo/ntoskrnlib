#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _RTL_ACTIVATION_CONTEXT_STACK_FRAME
    {
        [FieldOffset(0)]
        public IntPtr Previous;
        [FieldOffset(8)]
        public IntPtr ActivationContext;
        [FieldOffset(16)]
        public uint Flags;
    }
}