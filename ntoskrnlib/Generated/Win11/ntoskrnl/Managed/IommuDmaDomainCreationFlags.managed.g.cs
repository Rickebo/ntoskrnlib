using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IOMMU_DMA_DOMAIN_CREATION_FLAGS")]
    public sealed class IommuDmaDomainCreationFlags : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public ulong AsUlonglong { get => ReadHere<ulong>(nameof(AsUlonglong)); set => WriteHere(nameof(AsUlonglong), value); }

        public IommuDmaDomainCreationFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IommuDmaDomainCreationFlags>();
        }
    }
}