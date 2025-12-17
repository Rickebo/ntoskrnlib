using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FS_FILTER_PARAMETERS")]
    public sealed class FsFilterParameters : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag AcquireForModifiedPageWriter { get => ReadStructure<UnnamedTag>(nameof(AcquireForModifiedPageWriter)); set => WriteStructure(nameof(AcquireForModifiedPageWriter), value); }

        [Offset(0UL)]
        public UnnamedTag ReleaseForModifiedPageWriter { get => ReadStructure<UnnamedTag>(nameof(ReleaseForModifiedPageWriter)); set => WriteStructure(nameof(ReleaseForModifiedPageWriter), value); }

        [Offset(0UL)]
        public UnnamedTag AcquireForSectionSynchronization { get => ReadStructure<UnnamedTag>(nameof(AcquireForSectionSynchronization)); set => WriteStructure(nameof(AcquireForSectionSynchronization), value); }

        [Offset(0UL)]
        public UnnamedTag QueryOpen { get => ReadStructure<UnnamedTag>(nameof(QueryOpen)); set => WriteStructure(nameof(QueryOpen), value); }

        [Offset(0UL)]
        public UnnamedTag Others { get => ReadStructure<UnnamedTag>(nameof(Others)); set => WriteStructure(nameof(Others), value); }

        public FsFilterParameters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FsFilterParameters>();
        }
    }
}