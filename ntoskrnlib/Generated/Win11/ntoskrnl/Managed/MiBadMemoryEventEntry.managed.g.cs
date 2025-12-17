using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_BAD_MEMORY_EVENT_ENTRY")]
    public sealed class MiBadMemoryEventEntry : DynamicStructure
    {
        [Offset(0UL)]
        public uint BugCheckCode { get => ReadHere<uint>(nameof(BugCheckCode)); set => WriteHere(nameof(BugCheckCode), value); }

        [Offset(4UL)]
        public int Active { get => ReadHere<int>(nameof(Active)); set => WriteHere(nameof(Active), value); }

        [Offset(8UL)]
        public uint Data { get => ReadHere<uint>(nameof(Data)); set => WriteHere(nameof(Data), value); }

        [Offset(16UL)]
        public LargeInteger PhysicalAddress { get => ReadStructure<LargeInteger>(nameof(PhysicalAddress)); set => WriteStructure(nameof(PhysicalAddress), value); }

        [Offset(24UL)]
        public WorkQueueItem WorkItem { get => ReadStructure<WorkQueueItem>(nameof(WorkItem)); set => WriteStructure(nameof(WorkItem), value); }

        public MiBadMemoryEventEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiBadMemoryEventEntry>();
        }
    }
}