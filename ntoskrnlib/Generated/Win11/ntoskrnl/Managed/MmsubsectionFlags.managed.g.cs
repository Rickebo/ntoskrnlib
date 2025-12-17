using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMSUBSECTION_FLAGS")]
    public sealed class MmsubsectionFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint SubsectionAccessed { get => ReadHere<uint>(nameof(SubsectionAccessed)); set => WriteHere(nameof(SubsectionAccessed), value); }

        [Offset(0UL)]
        public uint Protection { get => ReadHere<uint>(nameof(Protection)); set => WriteHere(nameof(Protection), value); }

        [Offset(0UL)]
        public uint StartingSector4132 { get => ReadHere<uint>(nameof(StartingSector4132)); set => WriteHere(nameof(StartingSector4132), value); }

        [Offset(0UL)]
        public uint SubsectionStatic { get => ReadHere<uint>(nameof(SubsectionStatic)); set => WriteHere(nameof(SubsectionStatic), value); }

        [Offset(0UL)]
        public uint GlobalMemory { get => ReadHere<uint>(nameof(GlobalMemory)); set => WriteHere(nameof(GlobalMemory), value); }

        [Offset(0UL)]
        public uint Spare { get => ReadHere<uint>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(0UL)]
        public uint OnDereferenceList { get => ReadHere<uint>(nameof(OnDereferenceList)); set => WriteHere(nameof(OnDereferenceList), value); }

        [Offset(0UL)]
        public uint SectorEndOffset { get => ReadHere<uint>(nameof(SectorEndOffset)); set => WriteHere(nameof(SectorEndOffset), value); }

        [Offset(0UL)]
        public uint EntireField { get => ReadHere<uint>(nameof(EntireField)); set => WriteHere(nameof(EntireField), value); }

        public MmsubsectionFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmsubsectionFlags>();
        }
    }
}