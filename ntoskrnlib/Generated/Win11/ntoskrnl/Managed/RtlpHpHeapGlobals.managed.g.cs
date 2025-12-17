using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTLP_HP_HEAP_GLOBALS")]
    public sealed class RtlpHpHeapGlobals : DynamicStructure
    {
        [Offset(0UL)]
        public ulong HeapKey { get => ReadHere<ulong>(nameof(HeapKey)); set => WriteHere(nameof(HeapKey), value); }

        [Offset(8UL)]
        public ulong LfhKey { get => ReadHere<ulong>(nameof(LfhKey)); set => WriteHere(nameof(LfhKey), value); }

        [Offset(16UL)]
        public IntPtr FailureInfo { get => ReadHere<IntPtr>(nameof(FailureInfo)); set => WriteHere(nameof(FailureInfo), value); }

        [Offset(24UL)]
        public RtlpHeapCommitLimitData CommitLimitData { get => ReadStructure<RtlpHeapCommitLimitData>(nameof(CommitLimitData)); set => WriteStructure(nameof(CommitLimitData), value); }

        [Offset(40UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(40UL)]
        public uint CpuFeaturesChecked { get => ReadHere<uint>(nameof(CpuFeaturesChecked)); set => WriteHere(nameof(CpuFeaturesChecked), value); }

        [Offset(40UL)]
        public uint ErmsSupported { get => ReadHere<uint>(nameof(ErmsSupported)); set => WriteHere(nameof(ErmsSupported), value); }

        [Offset(40UL)]
        public uint BMI2Supported { get => ReadHere<uint>(nameof(BMI2Supported)); set => WriteHere(nameof(BMI2Supported), value); }

        [Offset(64UL)]
        public ulong RandomSeed { get => ReadHere<ulong>(nameof(RandomSeed)); set => WriteHere(nameof(RandomSeed), value); }

        public RtlpHpHeapGlobals(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlpHpHeapGlobals>();
        }
    }
}