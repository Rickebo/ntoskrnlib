using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!tagSWITCH_CONTEXT_DATA")]
    public sealed class tagSWITCHContextData : DynamicStructure
    {
        [Offset(0UL)]
        public ulong ullOsMaxVersionTested { get => ReadHere<ulong>(nameof(ullOsMaxVersionTested)); set => WriteHere(nameof(ullOsMaxVersionTested), value); }

        [Offset(8UL)]
        public uint ulTargetPlatform { get => ReadHere<uint>(nameof(ulTargetPlatform)); set => WriteHere(nameof(ulTargetPlatform), value); }

        [Offset(16UL)]
        public ulong ullContextMinimum { get => ReadHere<ulong>(nameof(ullContextMinimum)); set => WriteHere(nameof(ullContextMinimum), value); }

        [Offset(24UL)]
        public Guid guPlatform { get => ReadStructure<Guid>(nameof(guPlatform)); set => WriteStructure(nameof(guPlatform), value); }

        [Offset(40UL)]
        public Guid guMinPlatform { get => ReadStructure<Guid>(nameof(guMinPlatform)); set => WriteStructure(nameof(guMinPlatform), value); }

        [Offset(56UL)]
        public uint ulContextSource { get => ReadHere<uint>(nameof(ulContextSource)); set => WriteHere(nameof(ulContextSource), value); }

        [Offset(60UL)]
        public uint ulElementCount { get => ReadHere<uint>(nameof(ulElementCount)); set => WriteHere(nameof(ulElementCount), value); }

        [Offset(64UL)]
        [Length(48)]
        public DynamicArray guElements { get => ReadStructure<DynamicArray>(nameof(guElements)); set => WriteStructure(nameof(guElements), value); }

        public tagSWITCHContextData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<tagSWITCHContextData>();
        }
    }
}