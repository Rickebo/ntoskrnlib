#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _HEAP_LFH_FAST_REF
    {
        [FieldOffset(0)]
        public IntPtr Target;
        [FieldOffset(0)]
        public ulong Value;
        [FieldOffset(0)]
        public ulong RefCount;
    }
}