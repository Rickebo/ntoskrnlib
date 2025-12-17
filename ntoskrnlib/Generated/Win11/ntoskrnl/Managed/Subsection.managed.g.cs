using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SUBSECTION")]
    public sealed class Subsection : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ControlArea { get => ReadHere<IntPtr>(nameof(ControlArea)); set => WriteHere(nameof(ControlArea), value); }

        [Offset(8UL)]
        public IntPtr SubsectionBase { get => ReadHere<IntPtr>(nameof(SubsectionBase)); set => WriteHere(nameof(SubsectionBase), value); }

        [Offset(16UL)]
        public IntPtr NextSubsection { get => ReadHere<IntPtr>(nameof(NextSubsection)); set => WriteHere(nameof(NextSubsection), value); }

        [Offset(24UL)]
        public RtlAvlTree GlobalPerSessionHead { get => ReadStructure<RtlAvlTree>(nameof(GlobalPerSessionHead)); set => WriteStructure(nameof(GlobalPerSessionHead), value); }

        [Offset(24UL)]
        public IntPtr CreationWaitList { get => ReadHere<IntPtr>(nameof(CreationWaitList)); set => WriteHere(nameof(CreationWaitList), value); }

        [Offset(32UL)]
        public MmsubsectionFlags SubsectionFlags { get => ReadStructure<MmsubsectionFlags>(nameof(SubsectionFlags)); set => WriteStructure(nameof(SubsectionFlags), value); }

        [Offset(36UL)]
        public uint StartingSector { get => ReadHere<uint>(nameof(StartingSector)); set => WriteHere(nameof(StartingSector), value); }

        [Offset(40UL)]
        public uint NumberOfFullSectors { get => ReadHere<uint>(nameof(NumberOfFullSectors)); set => WriteHere(nameof(NumberOfFullSectors), value); }

        [Offset(44UL)]
        public uint PtesInSubsection { get => ReadHere<uint>(nameof(PtesInSubsection)); set => WriteHere(nameof(PtesInSubsection), value); }

        [Offset(48UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(52UL)]
        public uint UnusedPtes { get => ReadHere<uint>(nameof(UnusedPtes)); set => WriteHere(nameof(UnusedPtes), value); }

        [Offset(52UL)]
        public uint ExtentQueryNeeded { get => ReadHere<uint>(nameof(ExtentQueryNeeded)); set => WriteHere(nameof(ExtentQueryNeeded), value); }

        [Offset(52UL)]
        public uint Spare { get => ReadHere<uint>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        public Subsection(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Subsection>();
        }
    }
}