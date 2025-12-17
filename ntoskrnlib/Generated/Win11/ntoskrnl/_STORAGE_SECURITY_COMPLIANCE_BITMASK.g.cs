#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _STORAGE_SECURITY_COMPLIANCE_BITMASK
    {
        [FieldOffset(0)]
        public byte FIPS;
        [FieldOffset(0)]
        public byte Reserved;
        [FieldOffset(0)]
        public byte AsUchar;
    }
}