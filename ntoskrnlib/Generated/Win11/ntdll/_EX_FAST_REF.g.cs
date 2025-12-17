#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _EX_FAST_REF
    {
        [FieldOffset(0)]
        public IntPtr Object;
        [FieldOffset(0)]
        public ulong RefCnt;
        [FieldOffset(0)]
        public ulong Value;
    }
}