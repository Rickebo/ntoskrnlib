using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PPM_PLATFORM_STATES")]
    public sealed class PpmPlatformStates : DynamicStructure
    {
        [Offset(0UL)]
        public uint StateCount { get => ReadHere<uint>(nameof(StateCount)); set => WriteHere(nameof(StateCount), value); }

        [Offset(4UL)]
        public uint ProcessorCount { get => ReadHere<uint>(nameof(ProcessorCount)); set => WriteHere(nameof(ProcessorCount), value); }

        [Offset(8UL)]
        public byte CoordinatedInterface { get => ReadHere<byte>(nameof(CoordinatedInterface)); set => WriteHere(nameof(CoordinatedInterface), value); }

        [Offset(16UL)]
        public IntPtr IdleTest { get => ReadHere<IntPtr>(nameof(IdleTest)); set => WriteHere(nameof(IdleTest), value); }

        [Offset(24UL)]
        public IntPtr IdlePreExecute { get => ReadHere<IntPtr>(nameof(IdlePreExecute)); set => WriteHere(nameof(IdlePreExecute), value); }

        [Offset(32UL)]
        public IntPtr IdleComplete { get => ReadHere<IntPtr>(nameof(IdleComplete)); set => WriteHere(nameof(IdleComplete), value); }

        [Offset(40UL)]
        public IntPtr QueryPlatformStateResidency { get => ReadHere<IntPtr>(nameof(QueryPlatformStateResidency)); set => WriteHere(nameof(QueryPlatformStateResidency), value); }

        [Offset(48UL)]
        public IntPtr Accounting { get => ReadHere<IntPtr>(nameof(Accounting)); set => WriteHere(nameof(Accounting), value); }

        [Offset(56UL)]
        public uint DeepSleepState { get => ReadHere<uint>(nameof(DeepSleepState)); set => WriteHere(nameof(DeepSleepState), value); }

        [Offset(64UL)]
        [Length(1)]
        public DynamicArray State { get => ReadStructure<DynamicArray>(nameof(State)); set => WriteStructure(nameof(State), value); }

        public PpmPlatformStates(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PpmPlatformStates>();
        }
    }
}