using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXT_IOMMU_FLUSH_CONTEXT")]
    public sealed class ExtIommuFlushContext : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag Intel { get => ReadStructure<UnnamedTag>(nameof(Intel)); set => WriteStructure(nameof(Intel), value); }

        [Offset(0UL)]
        public UnnamedTag Amd { get => ReadStructure<UnnamedTag>(nameof(Amd)); set => WriteStructure(nameof(Amd), value); }

        public ExtIommuFlushContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExtIommuFlushContext>();
        }
    }
}