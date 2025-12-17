#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 2144)]
    public partial struct _HEAP_VAMGR_VASPACE
    {
        [FieldOffset(0)]
        public uint AddressSpaceType;
        [FieldOffset(8)]
        public ulong BaseAddress;
        [FieldOffset(16)]
        public _RTL_SPARSE_ARRAY VaRangeArray;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2128)]
        public byte[] VaRangeArrayBuffer;
    }
}