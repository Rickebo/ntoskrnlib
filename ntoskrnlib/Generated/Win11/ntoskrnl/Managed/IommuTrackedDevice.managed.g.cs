using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_TRACKED_DEVICE")]
    public sealed class IommuTrackedDevice : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public ulong Lock { get => ReadHere<ulong>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(24UL)]
        public IntPtr Iommu { get => ReadHere<IntPtr>(nameof(Iommu)); set => WriteHere(nameof(Iommu), value); }

        [Offset(32UL)]
        public uint IommuCapabilities { get => ReadHere<uint>(nameof(IommuCapabilities)); set => WriteHere(nameof(IommuCapabilities), value); }

        [Offset(36UL)]
        public uint ReferenceCount { get => ReadHere<uint>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(40UL)]
        public ulong SourceId { get => ReadHere<ulong>(nameof(SourceId)); set => WriteHere(nameof(SourceId), value); }

        [Offset(48UL)]
        public IommuSvmCapabilities Capabilities { get => ReadStructure<IommuSvmCapabilities>(nameof(Capabilities)); set => WriteStructure(nameof(Capabilities), value); }

        [Offset(52UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(56UL)]
        public ListEntry ActiveDeviceListHead { get => ReadStructure<ListEntry>(nameof(ActiveDeviceListHead)); set => WriteStructure(nameof(ActiveDeviceListHead), value); }

        [Offset(72UL)]
        public IntPtr DmaDevice { get => ReadHere<IntPtr>(nameof(DmaDevice)); set => WriteHere(nameof(DmaDevice), value); }

        [Offset(80UL)]
        public uint LastGroupFaultSequenceNumber { get => ReadHere<uint>(nameof(LastGroupFaultSequenceNumber)); set => WriteHere(nameof(LastGroupFaultSequenceNumber), value); }

        [Offset(88UL)]
        [Length(512)]
        public DynamicArray GroupFaultReferences { get => ReadStructure<DynamicArray>(nameof(GroupFaultReferences)); set => WriteStructure(nameof(GroupFaultReferences), value); }

        public IommuTrackedDevice(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuTrackedDevice>();
        }
    }
}