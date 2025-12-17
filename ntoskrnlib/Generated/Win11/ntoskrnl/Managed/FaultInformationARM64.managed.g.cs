using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FAULT_INFORMATION_ARM64")]
    public sealed class FaultInformationARM64 : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DomainHandle { get => ReadHere<IntPtr>(nameof(DomainHandle)); set => WriteHere(nameof(DomainHandle), value); }

        [Offset(8UL)]
        public IntPtr FaultAddress { get => ReadHere<IntPtr>(nameof(FaultAddress)); set => WriteHere(nameof(FaultAddress), value); }

        [Offset(16UL)]
        public IntPtr PhysicalDeviceObject { get => ReadHere<IntPtr>(nameof(PhysicalDeviceObject)); set => WriteHere(nameof(PhysicalDeviceObject), value); }

        [Offset(24UL)]
        public uint InputMappingId { get => ReadHere<uint>(nameof(InputMappingId)); set => WriteHere(nameof(InputMappingId), value); }

        [Offset(28UL)]
        public FaultInformationARM64Flags Flags { get => ReadStructure<FaultInformationARM64Flags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(32UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(40UL)]
        public ulong IommuBaseAddress { get => ReadHere<ulong>(nameof(IommuBaseAddress)); set => WriteHere(nameof(IommuBaseAddress), value); }

        public FaultInformationARM64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FaultInformationARM64>();
        }
    }
}