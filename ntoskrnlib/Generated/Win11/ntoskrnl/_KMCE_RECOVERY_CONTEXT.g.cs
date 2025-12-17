#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _KMCE_RECOVERY_CONTEXT
    {
        [FieldOffset(0)]
        public uint Flags;
        [FieldOffset(4)]
        public uint Reserved;
        [FieldOffset(8)]
        public ulong PhysicalAddress;
        [FieldOffset(8)]
        public IntPtr Record;
    }
}