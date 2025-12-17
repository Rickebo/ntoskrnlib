using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KI_COOPERATIVE_IDLE_SEARCH_GENERATION_ID")]
    public sealed class KiCooperativeIdleSearchGenerationId : DynamicStructure
    {
        [Offset(0UL)]
        public ulong FullId { get => ReadHere<ulong>(nameof(FullId)); set => WriteHere(nameof(FullId), value); }

        [Offset(0UL)]
        public ulong Empty { get => ReadHere<ulong>(nameof(Empty)); set => WriteHere(nameof(Empty), value); }

        [Offset(0UL)]
        public ulong MinorId { get => ReadHere<ulong>(nameof(MinorId)); set => WriteHere(nameof(MinorId), value); }

        [Offset(0UL)]
        public ulong MajorId { get => ReadHere<ulong>(nameof(MajorId)); set => WriteHere(nameof(MajorId), value); }

        public KiCooperativeIdleSearchGenerationId(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KiCooperativeIdleSearchGenerationId>();
        }
    }
}