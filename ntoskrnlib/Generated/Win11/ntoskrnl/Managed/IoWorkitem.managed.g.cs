using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IO_WORKITEM")]
    public sealed class IoWorkitem : DynamicStructure
    {
        [Offset(0UL)]
        public WorkQueueItem WorkItem { get => ReadStructure<WorkQueueItem>(nameof(WorkItem)); set => WriteStructure(nameof(WorkItem), value); }

        [Offset(32UL)]
        public IntPtr Routine { get => ReadHere<IntPtr>(nameof(Routine)); set => WriteHere(nameof(Routine), value); }

        [Offset(40UL)]
        public IntPtr IoObject { get => ReadHere<IntPtr>(nameof(IoObject)); set => WriteHere(nameof(IoObject), value); }

        [Offset(48UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(56UL)]
        public IntPtr WorkOnBehalfThread { get => ReadHere<IntPtr>(nameof(WorkOnBehalfThread)); set => WriteHere(nameof(WorkOnBehalfThread), value); }

        [Offset(64UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(68UL)]
        public Guid ActivityId { get => ReadStructure<Guid>(nameof(ActivityId)); set => WriteStructure(nameof(ActivityId), value); }

        public IoWorkitem(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoWorkitem>();
        }
    }
}