using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTLP_HEAP_COMMIT_LIMIT_DATA")]
    public sealed class RtlpHeapCommitLimitData : DynamicStructure
    {
        [Offset(0UL)]
        public ulong CommitLimitBytes { get => ReadHere<ulong>(nameof(CommitLimitBytes)); set => WriteHere(nameof(CommitLimitBytes), value); }

        [Offset(8UL)]
        public ulong CommitLimitFailureCode { get => ReadHere<ulong>(nameof(CommitLimitFailureCode)); set => WriteHere(nameof(CommitLimitFailureCode), value); }

        public RtlpHeapCommitLimitData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlpHeapCommitLimitData>();
        }
    }
}