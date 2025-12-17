#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _POP_FX_PERF_FLAGS
    {
        [FieldOffset(0)]
        public int Value;
        [FieldOffset(0)]
        public uint Progress;
        [FieldOffset(0)]
        public uint Reserved;
        [FieldOffset(0)]
        public uint Synchronicity;
        [FieldOffset(0)]
        public uint RequestPepCompleted;
        [FieldOffset(0)]
        public uint RequestSucceeded;
        [FieldOffset(0)]
        public uint NestedCallback;
    }
}