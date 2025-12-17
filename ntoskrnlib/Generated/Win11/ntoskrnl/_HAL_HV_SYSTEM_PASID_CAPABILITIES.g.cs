#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct _HAL_HV_SYSTEM_PASID_CAPABILITIES
    {
        [FieldOffset(0)]
        public uint SvmSupported;
        [FieldOffset(0)]
        public uint GpaAlwaysValid;
        [FieldOffset(0)]
        public uint PasidSupported;
        [FieldOffset(4)]
        public uint MaxPasidSpacePasidCount;
        [FieldOffset(8)]
        public uint MaxPrqSize;
        [FieldOffset(12)]
        public uint SvmIommuCount;
        [FieldOffset(16)]
        public uint MinIommuPasidCount;
    }
}