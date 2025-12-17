using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VI_VERIFIER_ISSUE")]
    public sealed class ViVerifierIssue : DynamicStructure
    {
        [Offset(0UL)]
        public ulong IssueType { get => ReadHere<ulong>(nameof(IssueType)); set => WriteHere(nameof(IssueType), value); }

        [Offset(8UL)]
        public IntPtr Address { get => ReadHere<IntPtr>(nameof(Address)); set => WriteHere(nameof(Address), value); }

        [Offset(16UL)]
        [Length(2)]
        public DynamicArray Parameters { get => ReadStructure<DynamicArray>(nameof(Parameters)); set => WriteStructure(nameof(Parameters), value); }

        public ViVerifierIssue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ViVerifierIssue>();
        }
    }
}