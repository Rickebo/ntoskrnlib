using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SPECIAL_PURPOSE_MEMORY_STATE")]
    public sealed class MiSpecialPurposeMemoryState : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry TypesList { get => ReadStructure<ListEntry>(nameof(TypesList)); set => WriteStructure(nameof(TypesList), value); }

        [Offset(16UL)]
        public ListEntry CacheEligibleList { get => ReadStructure<ListEntry>(nameof(CacheEligibleList)); set => WriteStructure(nameof(CacheEligibleList), value); }

        [Offset(0UL)]
        public IntPtr RegularMemoryParentPartitionObject { get => ReadHere<IntPtr>(nameof(RegularMemoryParentPartitionObject)); set => WriteHere(nameof(RegularMemoryParentPartitionObject), value); }

        [Offset(8UL)]
        public IntPtr SpecialPurposeMemoryParentHandle { get => ReadHere<IntPtr>(nameof(SpecialPurposeMemoryParentHandle)); set => WriteHere(nameof(SpecialPurposeMemoryParentHandle), value); }

        [Offset(16UL)]
        [Length(4)]
        public DynamicArray Attributes { get => ReadStructure<DynamicArray>(nameof(Attributes)); set => WriteStructure(nameof(Attributes), value); }

        [Offset(48UL)]
        public ExPushLock Lock { get => ReadStructure<ExPushLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        public MiSpecialPurposeMemoryState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSpecialPurposeMemoryState>();
        }
    }
}