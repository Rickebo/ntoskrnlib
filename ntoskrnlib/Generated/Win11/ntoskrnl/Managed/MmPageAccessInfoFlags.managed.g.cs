using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MM_PAGE_ACCESS_INFO_FLAGS")]
    public sealed class MmPageAccessInfoFlags : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag File { get => ReadStructure<UnnamedTag>(nameof(File)); set => WriteStructure(nameof(File), value); }

        [Offset(0UL)]
        public UnnamedTag Private { get => ReadStructure<UnnamedTag>(nameof(Private)); set => WriteStructure(nameof(Private), value); }

        public MmPageAccessInfoFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmPageAccessInfoFlags>();
        }
    }
}