#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _XSTATE_SAVE
    {
        [FieldOffset(0)]
        public IntPtr Prev;
        [FieldOffset(8)]
        public IntPtr Thread;
        [FieldOffset(16)]
        public byte Level;
        [FieldOffset(24)]
        public _XSTATE_CONTEXT XStateContext;
    }
}