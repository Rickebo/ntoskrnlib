#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _FAULT_INFORMATION_X64_FLAGS
    {
        [FieldOffset(0)]
        public uint FaultAddressValid;
        [FieldOffset(0)]
        public uint Reserved;
    }
}