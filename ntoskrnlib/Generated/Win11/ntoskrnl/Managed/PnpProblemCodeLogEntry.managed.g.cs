using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PNP_PROBLEM_CODE_LOG_ENTRY")]
    public sealed class PnpProblemCodeLogEntry : DynamicStructure
    {
        [Offset(0UL)]
        public LargeInteger Timestamp { get => ReadStructure<LargeInteger>(nameof(Timestamp)); set => WriteStructure(nameof(Timestamp), value); }

        [Offset(8UL)]
        public uint Operation { get => ReadHere<uint>(nameof(Operation)); set => WriteHere(nameof(Operation), value); }

        [Offset(12UL)]
        public uint ProblemCode { get => ReadHere<uint>(nameof(ProblemCode)); set => WriteHere(nameof(ProblemCode), value); }

        [Offset(16UL)]
        public int ProblemStatus { get => ReadHere<int>(nameof(ProblemStatus)); set => WriteHere(nameof(ProblemStatus), value); }

        public PnpProblemCodeLogEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PnpProblemCodeLogEntry>();
        }
    }
}