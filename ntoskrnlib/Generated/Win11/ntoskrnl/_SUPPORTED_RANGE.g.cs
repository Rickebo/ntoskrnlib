#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _SUPPORTED_RANGE
    {
        [FieldOffset(0)]
        public IntPtr Next;
        [FieldOffset(8)]
        public uint SystemAddressSpace;
        [FieldOffset(16)]
        public long SystemBase;
        [FieldOffset(24)]
        public long Base;
        [FieldOffset(32)]
        public long Limit;
    }
}