using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_REGISTERED_INTERRUPT_CONTROLLER")]
    public sealed class RegisteredInterruptController : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public IntPtr InternalData { get => ReadHere<IntPtr>(nameof(InternalData)); set => WriteHere(nameof(InternalData), value); }

        [Offset(24UL)]
        public uint InternalDataSize { get => ReadHere<uint>(nameof(InternalDataSize)); set => WriteHere(nameof(InternalDataSize), value); }

        [Offset(32UL)]
        public InterruptFunctionTable FunctionTable { get => ReadStructure<InterruptFunctionTable>(nameof(FunctionTable)); set => WriteStructure(nameof(FunctionTable), value); }

        [Offset(240UL)]
        public uint KnownType { get => ReadHere<uint>(nameof(KnownType)); set => WriteHere(nameof(KnownType), value); }

        [Offset(244UL)]
        public uint Capabilities { get => ReadHere<uint>(nameof(Capabilities)); set => WriteHere(nameof(Capabilities), value); }

        [Offset(248UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(252UL)]
        public uint MaxPriority { get => ReadHere<uint>(nameof(MaxPriority)); set => WriteHere(nameof(MaxPriority), value); }

        [Offset(256UL)]
        public uint UnitId { get => ReadHere<uint>(nameof(UnitId)); set => WriteHere(nameof(UnitId), value); }

        [Offset(264UL)]
        public ListEntry LinesHead { get => ReadStructure<ListEntry>(nameof(LinesHead)); set => WriteStructure(nameof(LinesHead), value); }

        [Offset(280UL)]
        public ListEntry OutputLinesHead { get => ReadStructure<ListEntry>(nameof(OutputLinesHead)); set => WriteStructure(nameof(OutputLinesHead), value); }

        [Offset(296UL)]
        public int MinLine { get => ReadHere<int>(nameof(MinLine)); set => WriteHere(nameof(MinLine), value); }

        [Offset(300UL)]
        public int MaxLine { get => ReadHere<int>(nameof(MaxLine)); set => WriteHere(nameof(MaxLine), value); }

        [Offset(304UL)]
        public uint MaxClusterSize { get => ReadHere<uint>(nameof(MaxClusterSize)); set => WriteHere(nameof(MaxClusterSize), value); }

        [Offset(308UL)]
        public uint MaxClusters { get => ReadHere<uint>(nameof(MaxClusters)); set => WriteHere(nameof(MaxClusters), value); }

        [Offset(312UL)]
        public uint InterruptReplayDataSize { get => ReadHere<uint>(nameof(InterruptReplayDataSize)); set => WriteHere(nameof(InterruptReplayDataSize), value); }

        [Offset(316UL)]
        public uint Problem { get => ReadHere<uint>(nameof(Problem)); set => WriteHere(nameof(Problem), value); }

        [Offset(320UL)]
        public int ProblemStatus { get => ReadHere<int>(nameof(ProblemStatus)); set => WriteHere(nameof(ProblemStatus), value); }

        [Offset(328UL)]
        public IntPtr ProblemSourceFile { get => ReadHere<IntPtr>(nameof(ProblemSourceFile)); set => WriteHere(nameof(ProblemSourceFile), value); }

        [Offset(336UL)]
        public uint ProblemSourceLine { get => ReadHere<uint>(nameof(ProblemSourceLine)); set => WriteHere(nameof(ProblemSourceLine), value); }

        [Offset(340UL)]
        public uint CustomProblem { get => ReadHere<uint>(nameof(CustomProblem)); set => WriteHere(nameof(CustomProblem), value); }

        [Offset(344UL)]
        public int CustomProblemStatus { get => ReadHere<int>(nameof(CustomProblemStatus)); set => WriteHere(nameof(CustomProblemStatus), value); }

        [Offset(352UL)]
        public UnicodeString ResourceId { get => ReadStructure<UnicodeString>(nameof(ResourceId)); set => WriteStructure(nameof(ResourceId), value); }

        [Offset(368UL)]
        public IntPtr PowerHandle { get => ReadHere<IntPtr>(nameof(PowerHandle)); set => WriteHere(nameof(PowerHandle), value); }

        public RegisteredInterruptController(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RegisteredInterruptController>();
        }
    }
}