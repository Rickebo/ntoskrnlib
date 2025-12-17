#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _HEAP_LFH_THREAD_DATA
    {
        [FieldOffset(0)]
        public ushort SlotMapRef;
        [FieldOffset(2)]
        public ushort HeatMapRef;
        [FieldOffset(4)]
        public byte CachedProcIndex;
        [FieldOffset(5)]
        public byte ContentionRemapCount;
        [FieldOffset(6)]
        public ushort Spare;
        [FieldOffset(0)]
        public IntPtr AllBits;
    }
}