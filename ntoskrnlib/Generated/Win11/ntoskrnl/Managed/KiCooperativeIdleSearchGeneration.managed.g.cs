using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KI_COOPERATIVE_IDLE_SEARCH_GENERATION")]
    public sealed class KiCooperativeIdleSearchGeneration : DynamicStructure
    {
        [Offset(0UL)]
        public KiCooperativeIdleSearchGenerationId GenerationId { get => ReadStructure<KiCooperativeIdleSearchGenerationId>(nameof(GenerationId)); set => WriteStructure(nameof(GenerationId), value); }

        [Offset(8UL)]
        public ushort AllocatedTargetEntries { get => ReadHere<ushort>(nameof(AllocatedTargetEntries)); set => WriteHere(nameof(AllocatedTargetEntries), value); }

        [Offset(10UL)]
        public ushort ActiveTargetEntries { get => ReadHere<ushort>(nameof(ActiveTargetEntries)); set => WriteHere(nameof(ActiveTargetEntries), value); }

        [Offset(12UL)]
        public uint Spare { get => ReadHere<uint>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(16UL)]
        [Length(1)]
        public DynamicArray ExtensionStart { get => ReadStructure<DynamicArray>(nameof(ExtensionStart)); set => WriteStructure(nameof(ExtensionStart), value); }

        public KiCooperativeIdleSearchGeneration(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KiCooperativeIdleSearchGeneration>();
        }
    }
}