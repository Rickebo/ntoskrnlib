#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _HEAP_LFH_PTRREF_LIST
    {
        [FieldOffset(0)]
        public ushort Flink;
        [FieldOffset(2)]
        public ushort Blink;
    }
}