using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PAGE_MOVE_PROGRESS_STATE")]
    public sealed class MiPageMoveProgressState : DynamicStructure
    {
        [Offset(0UL)]
        public ulong InProgressProcessors { get => ReadHere<ulong>(nameof(InProgressProcessors)); set => WriteHere(nameof(InProgressProcessors), value); }

        [Offset(0UL)]
        public ulong SequenceNumber { get => ReadHere<ulong>(nameof(SequenceNumber)); set => WriteHere(nameof(SequenceNumber), value); }

        [Offset(0UL)]
        public long EntireValue { get => ReadHere<long>(nameof(EntireValue)); set => WriteHere(nameof(EntireValue), value); }

        public MiPageMoveProgressState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPageMoveProgressState>();
        }
    }
}