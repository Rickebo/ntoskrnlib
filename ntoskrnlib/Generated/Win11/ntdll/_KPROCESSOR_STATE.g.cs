#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 1472)]
    public partial struct _KPROCESSOR_STATE
    {
        [FieldOffset(0)]
        public _KSPECIAL_REGISTERS SpecialRegisters;
        [FieldOffset(240)]
        public _CONTEXT ContextFrame;
    }
}