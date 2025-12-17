#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _RTL_CALLER_ALLOCATED_ACTIVATION_CONTEXT_STACK_FRAME_EXTENDED
    {
        [FieldOffset(0)]
        public ulong Size;
        [FieldOffset(8)]
        public uint Format;
        [FieldOffset(16)]
        public _RTL_ACTIVATION_CONTEXT_STACK_FRAME Frame;
        [FieldOffset(40)]
        public IntPtr Extra1;
        [FieldOffset(48)]
        public IntPtr Extra2;
        [FieldOffset(56)]
        public IntPtr Extra3;
        [FieldOffset(64)]
        public IntPtr Extra4;
    }
}