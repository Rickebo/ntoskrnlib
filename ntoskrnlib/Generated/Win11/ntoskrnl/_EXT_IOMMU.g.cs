#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 184)]
    public partial struct _EXT_IOMMU
    {
        [FieldOffset(0)]
        public IntPtr Context;
        [FieldOffset(8)]
        public uint Type;
        [FieldOffset(16)]
        public _EXT_IOMMU_CAPABILITIES Capabilities;
        [FieldOffset(24)]
        public uint MaxOutputAddressWidth;
        [FieldOffset(28)]
        public _unnamed_tag_ Flags;
        [FieldOffset(30)]
        public ushort PciSegmentNumber;
        [FieldOffset(32)]
        public _EXT_IOMMU_FUNCTION_TABLE FunctionTable;
    }
}