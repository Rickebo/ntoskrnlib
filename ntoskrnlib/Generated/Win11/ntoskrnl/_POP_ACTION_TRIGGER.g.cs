#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _POP_ACTION_TRIGGER
    {
        [FieldOffset(0)]
        public uint Type;
        [FieldOffset(4)]
        public uint Flags;
        [FieldOffset(8)]
        public IntPtr Wait;
        [FieldOffset(16)]
        public IntPtr DiagnosticContext;
        [FieldOffset(24)]
        public _unnamed_tag_ Battery;
        [FieldOffset(24)]
        public _unnamed_tag_ Button;
    }
}