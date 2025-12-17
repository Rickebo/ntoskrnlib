#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial struct _IOMMU_DMA_DOMAIN
    {
        [FieldOffset(0)]
        public IntPtr DmaDomainOwner;
        [FieldOffset(8)]
        public uint DomainType;
        [FieldOffset(12)]
        public uint TranslationType;
        [FieldOffset(16)]
        public _LIST_ENTRY HardwareDomainListHead;
        [FieldOffset(32)]
        public ulong HardwareDomainListLock;
        [FieldOffset(40)]
        public IntPtr DmarptState;
        [FieldOffset(48)]
        public uint DomainId;
        [FieldOffset(52)]
        public byte IsStage1;
        [FieldOffset(56)]
        public uint Asid;
        [FieldOffset(64)]
        public IntPtr LogicalAllocator;
        [FieldOffset(72)]
        public _LIST_ENTRY AttachedDevicesList;
        [FieldOffset(88)]
        public int AttachedDevicesListLock;
        [FieldOffset(92)]
        public uint HvReferences;
        [FieldOffset(96)]
        public byte HvDomainIdAllocated;
        [FieldOffset(104)]
        public _EX_PUSH_LOCK HvPushLock;
    }
}