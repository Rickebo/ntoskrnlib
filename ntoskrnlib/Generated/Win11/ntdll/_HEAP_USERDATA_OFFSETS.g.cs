#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _HEAP_USERDATA_OFFSETS
    {
        [FieldOffset(0)]
        public ushort FirstAllocationOffset;
        [FieldOffset(2)]
        public ushort BlockStride;
        [FieldOffset(0)]
        public uint StrideAndOffset;
    }
}