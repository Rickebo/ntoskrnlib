using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PPM_PLATFORM_STATE")]
    public sealed class PpmPlatformState : DynamicStructure
    {
        [Offset(0UL)]
        public ulong LevelId { get => ReadHere<ulong>(nameof(LevelId)); set => WriteHere(nameof(LevelId), value); }

        [Offset(8UL)]
        public uint Latency { get => ReadHere<uint>(nameof(Latency)); set => WriteHere(nameof(Latency), value); }

        [Offset(12UL)]
        public uint BreakEvenDuration { get => ReadHere<uint>(nameof(BreakEvenDuration)); set => WriteHere(nameof(BreakEvenDuration), value); }

        [Offset(16UL)]
        public PpmVetoAccounting VetoAccounting { get => ReadStructure<PpmVetoAccounting>(nameof(VetoAccounting)); set => WriteStructure(nameof(VetoAccounting), value); }

        [Offset(56UL)]
        public byte TransitionDebugger { get => ReadHere<byte>(nameof(TransitionDebugger)); set => WriteHere(nameof(TransitionDebugger), value); }

        [Offset(57UL)]
        public byte Platform { get => ReadHere<byte>(nameof(Platform)); set => WriteHere(nameof(Platform), value); }

        [Offset(58UL)]
        public byte Enabled { get => ReadHere<byte>(nameof(Enabled)); set => WriteHere(nameof(Enabled), value); }

        [Offset(59UL)]
        public byte CoordinatedDependencies { get => ReadHere<byte>(nameof(CoordinatedDependencies)); set => WriteHere(nameof(CoordinatedDependencies), value); }

        [Offset(60UL)]
        public uint DependencyListCount { get => ReadHere<uint>(nameof(DependencyListCount)); set => WriteHere(nameof(DependencyListCount), value); }

        [Offset(64UL)]
        public KaffinityEx Processors { get => ReadStructure<KaffinityEx>(nameof(Processors)); set => WriteStructure(nameof(Processors), value); }

        [Offset(328UL)]
        public UnicodeString Name { get => ReadStructure<UnicodeString>(nameof(Name)); set => WriteStructure(nameof(Name), value); }

        [Offset(344UL)]
        public IntPtr DependencyLists { get => ReadHere<IntPtr>(nameof(DependencyLists)); set => WriteHere(nameof(DependencyLists), value); }

        [Offset(352UL)]
        public PpmCoordinatedSynchronization Synchronization { get => ReadStructure<PpmCoordinatedSynchronization>(nameof(Synchronization)); set => WriteStructure(nameof(Synchronization), value); }

        [Offset(360UL)]
        public ulong EnterTime { get => ReadHere<ulong>(nameof(EnterTime)); set => WriteHere(nameof(EnterTime), value); }

        [Offset(384UL)]
        public int RefCount { get => ReadHere<int>(nameof(RefCount)); set => WriteHere(nameof(RefCount), value); }

        [Offset(384UL)]
        [Length(64)]
        public DynamicArray CacheAlign0 { get => ReadStructure<DynamicArray>(nameof(CacheAlign0)); set => WriteStructure(nameof(CacheAlign0), value); }

        public PpmPlatformState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PpmPlatformState>();
        }
    }
}