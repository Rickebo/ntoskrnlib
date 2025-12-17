#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public partial struct _HALP_DMA_DOMAIN_OBJECT
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public _LARGE_INTEGER MaximumPhysicalAddress;
        [FieldOffset(24)]
        public _LARGE_INTEGER BoundaryAddressMultiple;
        [FieldOffset(32)]
        public byte CacheCoherent;
        [FieldOffset(33)]
        public byte FirmwareReserved;
        [FieldOffset(40)]
        public IntPtr IommuDomainPointer;
        [FieldOffset(48)]
        public uint TranslationType;
        [FieldOffset(56)]
        public IntPtr OwningAdapter;
        [FieldOffset(64)]
        public _RTL_RB_TREE CommonBufferRoot;
        [FieldOffset(80)]
        public ulong CommonBufferTreeLock;
        [FieldOffset(88)]
        public _LIST_ENTRY VectorCommonBufferListHead;
        [FieldOffset(104)]
        public ulong VectorCommonBufferLock;
        [FieldOffset(112)]
        public uint DomainRefCount;
    }
}