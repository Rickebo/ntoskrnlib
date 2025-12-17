using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MM_PAGED_POOL_INFO")]
    public sealed class MmPagedPoolInfo : DynamicStructure
    {
        [Offset(0UL)]
        public ExPushLock Lock { get => ReadStructure<ExPushLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(8UL)]
        public ulong MaximumSize { get => ReadHere<ulong>(nameof(MaximumSize)); set => WriteHere(nameof(MaximumSize), value); }

        [Offset(16UL)]
        public ulong AllocatedPagedPool { get => ReadHere<ulong>(nameof(AllocatedPagedPool)); set => WriteHere(nameof(AllocatedPagedPool), value); }

        public MmPagedPoolInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmPagedPoolInfo>();
        }
    }
}