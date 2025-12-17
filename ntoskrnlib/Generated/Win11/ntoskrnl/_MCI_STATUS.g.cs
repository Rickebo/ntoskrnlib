#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MCI_STATUS
    {
        [FieldOffset(0)]
        public _MCI_STATUS_BITS_COMMON CommonBits;
        [FieldOffset(0)]
        public _MCI_STATUS_AMD_BITS AmdBits;
        [FieldOffset(0)]
        public _MCI_STATUS_INTEL_BITS IntelBits;
        [FieldOffset(0)]
        public ulong QuadPart;
    }
}