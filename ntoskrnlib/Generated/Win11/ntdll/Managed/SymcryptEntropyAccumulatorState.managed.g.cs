using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_SYMCRYPT_ENTROPY_ACCUMULATOR_STATE")]
    public sealed class SymcryptEntropyAccumulatorState : DynamicStructure
    {
        [Offset(0UL)]
        [Length(256)]
        public DynamicArray buffer { get => ReadStructure<DynamicArray>(nameof(buffer)); set => WriteStructure(nameof(buffer), value); }

        [Offset(256UL)]
        public Kdpc Dpc { get => ReadStructure<Kdpc>(nameof(Dpc)); set => WriteStructure(nameof(Dpc), value); }

        [Offset(320UL)]
        public ulong nSamplesAccumulated { get => ReadHere<ulong>(nameof(nSamplesAccumulated)); set => WriteHere(nameof(nSamplesAccumulated), value); }

        [Offset(328UL)]
        public ulong nHealthTestFailures { get => ReadHere<ulong>(nameof(nHealthTestFailures)); set => WriteHere(nameof(nHealthTestFailures), value); }

        [Offset(336UL)]
        public IntPtr pCombinedSampleBuffer { get => ReadHere<IntPtr>(nameof(pCombinedSampleBuffer)); set => WriteHere(nameof(pCombinedSampleBuffer), value); }

        [Offset(344UL)]
        public ulong nRawSamples { get => ReadHere<ulong>(nameof(nRawSamples)); set => WriteHere(nameof(nRawSamples), value); }

        [Offset(352UL)]
        public uint accumulatorId { get => ReadHere<uint>(nameof(accumulatorId)); set => WriteHere(nameof(accumulatorId), value); }

        [Offset(356UL)]
        public uint nDPCScheduleFailures { get => ReadHere<uint>(nameof(nDPCScheduleFailures)); set => WriteHere(nameof(nDPCScheduleFailures), value); }

        [Offset(360UL)]
        public byte dpcInProgress { get => ReadHere<byte>(nameof(dpcInProgress)); set => WriteHere(nameof(dpcInProgress), value); }

        public SymcryptEntropyAccumulatorState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SymcryptEntropyAccumulatorState>();
        }
    }
}