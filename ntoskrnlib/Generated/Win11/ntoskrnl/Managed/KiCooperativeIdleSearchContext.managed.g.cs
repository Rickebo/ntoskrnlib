using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KI_COOPERATIVE_IDLE_SEARCH_CONTEXT")]
    public sealed class KiCooperativeIdleSearchContext : DynamicStructure
    {
        [Offset(0UL)]
        public ulong SearchContextLock { get => ReadHere<ulong>(nameof(SearchContextLock)); set => WriteHere(nameof(SearchContextLock), value); }

        [Offset(8UL)]
        public ulong SearchingProcessors { get => ReadHere<ulong>(nameof(SearchingProcessors)); set => WriteHere(nameof(SearchingProcessors), value); }

        [Offset(16UL)]
        public KiCooperativeIdleSearchGenerationId NextGenerationId { get => ReadStructure<KiCooperativeIdleSearchGenerationId>(nameof(NextGenerationId)); set => WriteStructure(nameof(NextGenerationId), value); }

        [Offset(24UL)]
        [Length(64)]
        public DynamicArray GenerationIds { get => ReadStructure<DynamicArray>(nameof(GenerationIds)); set => WriteStructure(nameof(GenerationIds), value); }

        [Offset(536UL)]
        [Length(64)]
        public DynamicArray Generations { get => ReadStructure<DynamicArray>(nameof(Generations)); set => WriteStructure(nameof(Generations), value); }

        [Offset(1048UL)]
        public ulong Affinity { get => ReadHere<ulong>(nameof(Affinity)); set => WriteHere(nameof(Affinity), value); }

        [Offset(1056UL)]
        public ushort AllocatedTargetEntries { get => ReadHere<ushort>(nameof(AllocatedTargetEntries)); set => WriteHere(nameof(AllocatedTargetEntries), value); }

        [Offset(1058UL)]
        public ushort ActiveTargetEntries { get => ReadHere<ushort>(nameof(ActiveTargetEntries)); set => WriteHere(nameof(ActiveTargetEntries), value); }

        [Offset(1060UL)]
        public byte LowProcIndex { get => ReadHere<byte>(nameof(LowProcIndex)); set => WriteHere(nameof(LowProcIndex), value); }

        [Offset(1061UL)]
        public byte HighProcIndex { get => ReadHere<byte>(nameof(HighProcIndex)); set => WriteHere(nameof(HighProcIndex), value); }

        [Offset(1062UL)]
        public ushort Group { get => ReadHere<ushort>(nameof(Group)); set => WriteHere(nameof(Group), value); }

        [Offset(1064UL)]
        [Length(1)]
        public DynamicArray ExtensionStart { get => ReadStructure<DynamicArray>(nameof(ExtensionStart)); set => WriteStructure(nameof(ExtensionStart), value); }

        public KiCooperativeIdleSearchContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KiCooperativeIdleSearchContext>();
        }
    }
}