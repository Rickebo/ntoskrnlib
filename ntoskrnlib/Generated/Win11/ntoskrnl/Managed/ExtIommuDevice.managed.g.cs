using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_DEVICE")]
    public sealed class ExtIommuDevice : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(8UL)]
        public IntPtr Iommu { get => ReadHere<IntPtr>(nameof(Iommu)); set => WriteHere(nameof(Iommu), value); }

        [Offset(16UL)]
        public IntPtr Domain { get => ReadHere<IntPtr>(nameof(Domain)); set => WriteHere(nameof(Domain), value); }

        [Offset(24UL)]
        public ulong AssociatedDomainId { get => ReadHere<ulong>(nameof(AssociatedDomainId)); set => WriteHere(nameof(AssociatedDomainId), value); }

        [Offset(32UL)]
        public ushort FirmwareDomainId { get => ReadHere<ushort>(nameof(FirmwareDomainId)); set => WriteHere(nameof(FirmwareDomainId), value); }

        [Offset(34UL)]
        public byte FaultReportingEnabled { get => ReadHere<byte>(nameof(FaultReportingEnabled)); set => WriteHere(nameof(FaultReportingEnabled), value); }

        [Offset(35UL)]
        public byte IsReservedDevice { get => ReadHere<byte>(nameof(IsReservedDevice)); set => WriteHere(nameof(IsReservedDevice), value); }

        public ExtIommuDevice(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExtIommuDevice>();
        }
    }
}