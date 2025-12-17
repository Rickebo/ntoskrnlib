#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _FAULT_INFORMATION_ARM64
    {
        [FieldOffset(0)]
        public IntPtr DomainHandle;
        [FieldOffset(8)]
        public IntPtr FaultAddress;
        [FieldOffset(16)]
        public IntPtr PhysicalDeviceObject;
        [FieldOffset(24)]
        public uint InputMappingId;
        [FieldOffset(28)]
        public _FAULT_INFORMATION_ARM64_FLAGS Flags;
        [FieldOffset(32)]
        public uint Type;
        [FieldOffset(40)]
        public ulong IommuBaseAddress;
    }
}