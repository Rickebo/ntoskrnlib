#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public partial struct _DBGKM_EXCEPTION64
    {
        [FieldOffset(0)]
        public _EXCEPTION_RECORD64 ExceptionRecord;
        [FieldOffset(152)]
        public uint FirstChance;
    }
}