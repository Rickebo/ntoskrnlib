#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _SEGMENT_HEAP_EXTRA
    {
        [FieldOffset(0)]
        public ushort AllocationTag;
        [FieldOffset(2)]
        public byte InterceptorIndex;
        [FieldOffset(2)]
        public byte UserFlags;
        [FieldOffset(3)]
        public byte ExtraSizeInUnits;
        [FieldOffset(8)]
        public IntPtr Settable;
    }
}