#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _HEAP_STOP_ON_TAG
    {
        [FieldOffset(0)]
        public uint HeapAndTagIndex;
        [FieldOffset(0)]
        public ushort TagIndex;
        [FieldOffset(2)]
        public ushort HeapIndex;
    }
}