#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _IOMMU_SVM_CAPABILITIES
    {
        [FieldOffset(0)]
        public uint AtsCapability;
        [FieldOffset(0)]
        public uint PriCapability;
        [FieldOffset(0)]
        public uint PasidCapability;
        [FieldOffset(0)]
        public uint Rsvd0;
        [FieldOffset(0)]
        public _unnamed_tag_ CapReg;
        [FieldOffset(0)]
        public _unnamed_tag_ EnabledCaps;
        [FieldOffset(0)]
        public _unnamed_tag_ DeviceInformation;
        [FieldOffset(0)]
        public uint AtsPriPasidBits;
        [FieldOffset(0)]
        public uint CapRegBits;
        [FieldOffset(0)]
        public uint EnabledCapsBits;
        [FieldOffset(0)]
        public uint DeviceInformationBits;
        [FieldOffset(0)]
        public uint Rsvd1;
        [FieldOffset(0)]
        public uint AsULONG;
    }
}