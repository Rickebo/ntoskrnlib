#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _DBGKD_CONTINUE2
    {
        [FieldOffset(0)]
        public int ContinueStatus;
        [FieldOffset(4)]
        public _AMD64_DBGKD_CONTROL_SET ControlSet;
        [FieldOffset(4)]
        public _DBGKD_ANY_CONTROL_SET AnyControlSet;
    }
}