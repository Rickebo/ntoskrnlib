#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _RTLP_HP_METADATA_HEAP_CTX
    {
        [FieldOffset(0)]
        public IntPtr Heap;
        [FieldOffset(8)]
        public _RTL_RUN_ONCE InitOnce;
    }
}