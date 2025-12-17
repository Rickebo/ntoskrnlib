#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial struct _EXT_IOMMU_DOMAIN
    {
        [FieldOffset(0)]
        public uint DomainType;
        [FieldOffset(4)]
        public uint TranslationType;
        [FieldOffset(8)]
        public _unnamed_tag_ Flags;
        [FieldOffset(10)]
        public ushort FirmwareDomainId;
        [FieldOffset(16)]
        public _EXT_IOMMU_DOMAIN_SETTINGS Settings;
        [FieldOffset(48)]
        public uint ContextId;
        [FieldOffset(52)]
        public uint DeviceCount;
        [FieldOffset(56)]
        public _LIST_ENTRY Devices;
        [FieldOffset(72)]
        public _EXT_ENV_SPINLOCK Lock;
        [FieldOffset(104)]
        public IntPtr S2Domain;
    }
}