#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _FAULT_INFORMATION_X64
    {
        [FieldOffset(0)]
        public IntPtr DomainHandle;
        [FieldOffset(8)]
        public IntPtr FaultAddress;
        [FieldOffset(16)]
        public _FAULT_INFORMATION_X64_FLAGS Flags;
        [FieldOffset(20)]
        public uint Type;
        [FieldOffset(24)]
        public ulong IommuBaseAddress;
        [FieldOffset(32)]
        public uint PciSegment;
    }
}