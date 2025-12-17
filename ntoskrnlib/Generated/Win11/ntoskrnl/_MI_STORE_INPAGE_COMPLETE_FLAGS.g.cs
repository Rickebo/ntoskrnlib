#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MI_STORE_INPAGE_COMPLETE_FLAGS
    {
        [FieldOffset(0)]
        public uint EntireFlags;
        [FieldOffset(0)]
        public uint StoreFault;
        [FieldOffset(0)]
        public uint LowResourceFailure;
        [FieldOffset(0)]
        public uint Spare;
    }
}