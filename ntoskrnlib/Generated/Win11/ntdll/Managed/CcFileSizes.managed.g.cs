using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_CC_FILE_SIZES")]
    public sealed class CcFileSizes : DynamicStructure
    {
        [Offset(0UL)]
        public LargeInteger AllocationSize { get => ReadStructure<LargeInteger>(nameof(AllocationSize)); set => WriteStructure(nameof(AllocationSize), value); }

        [Offset(8UL)]
        public LargeInteger FileSize { get => ReadStructure<LargeInteger>(nameof(FileSize)); set => WriteStructure(nameof(FileSize), value); }

        [Offset(16UL)]
        public LargeInteger ValidDataLength { get => ReadStructure<LargeInteger>(nameof(ValidDataLength)); set => WriteStructure(nameof(ValidDataLength), value); }

        public CcFileSizes(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CcFileSizes>();
        }
    }
}