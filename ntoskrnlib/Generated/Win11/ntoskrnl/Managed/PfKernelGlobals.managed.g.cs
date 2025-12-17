using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PF_KERNEL_GLOBALS")]
    public sealed class PfKernelGlobals : DynamicStructure
    {
        [Offset(0UL)]
        public ulong AccessBufferAgeThreshold { get => ReadHere<ulong>(nameof(AccessBufferAgeThreshold)); set => WriteHere(nameof(AccessBufferAgeThreshold), value); }

        [Offset(8UL)]
        public int StreamSequenceNumber { get => ReadHere<int>(nameof(StreamSequenceNumber)); set => WriteHere(nameof(StreamSequenceNumber), value); }

        [Offset(12UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(16UL)]
        public int ScenarioPrefetchCount { get => ReadHere<int>(nameof(ScenarioPrefetchCount)); set => WriteHere(nameof(ScenarioPrefetchCount), value); }

        public PfKernelGlobals(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PfKernelGlobals>();
        }
    }
}