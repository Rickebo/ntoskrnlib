#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 84)]
    public partial struct _DBGKM_EXCEPTION32
    {
        [FieldOffset(0)]
        public _EXCEPTION_RECORD32 ExceptionRecord;
        [FieldOffset(80)]
        public uint FirstChance;
    }
}