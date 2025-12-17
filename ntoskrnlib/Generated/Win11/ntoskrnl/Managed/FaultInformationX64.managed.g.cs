using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FAULT_INFORMATION_X64")]
    public sealed class FaultInformationX64 : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DomainHandle { get => ReadHere<IntPtr>(nameof(DomainHandle)); set => WriteHere(nameof(DomainHandle), value); }

        [Offset(8UL)]
        public IntPtr FaultAddress { get => ReadHere<IntPtr>(nameof(FaultAddress)); set => WriteHere(nameof(FaultAddress), value); }

        [Offset(16UL)]
        public FaultInformationX64Flags Flags { get => ReadStructure<FaultInformationX64Flags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(20UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(24UL)]
        public ulong IommuBaseAddress { get => ReadHere<ulong>(nameof(IommuBaseAddress)); set => WriteHere(nameof(IommuBaseAddress), value); }

        [Offset(32UL)]
        public uint PciSegment { get => ReadHere<uint>(nameof(PciSegment)); set => WriteHere(nameof(PciSegment), value); }

        public FaultInformationX64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FaultInformationX64>();
        }
    }
}