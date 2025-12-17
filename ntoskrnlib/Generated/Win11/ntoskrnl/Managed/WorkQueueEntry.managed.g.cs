using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WORK_QUEUE_ENTRY")]
    public sealed class WorkQueueEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry WorkQueueLinks { get => ReadStructure<ListEntry>(nameof(WorkQueueLinks)); set => WriteStructure(nameof(WorkQueueLinks), value); }

        [Offset(16UL)]
        public UnnamedTag Parameters { get => ReadStructure<UnnamedTag>(nameof(Parameters)); set => WriteStructure(nameof(Parameters), value); }

        [Offset(128UL)]
        public uint Function { get => ReadHere<uint>(nameof(Function)); set => WriteHere(nameof(Function), value); }

        [Offset(136UL)]
        public IntPtr Partition { get => ReadHere<IntPtr>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        [Offset(144UL)]
        public IntPtr PrivateVolumeCacheMap { get => ReadHere<IntPtr>(nameof(PrivateVolumeCacheMap)); set => WriteHere(nameof(PrivateVolumeCacheMap), value); }

        [Offset(152UL)]
        public IntPtr NumaNode { get => ReadHere<IntPtr>(nameof(NumaNode)); set => WriteHere(nameof(NumaNode), value); }

        public WorkQueueEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WorkQueueEntry>();
        }
    }
}