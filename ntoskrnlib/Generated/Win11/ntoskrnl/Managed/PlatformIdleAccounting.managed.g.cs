using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PLATFORM_IDLE_ACCOUNTING")]
    public sealed class PlatformIdleAccounting : DynamicStructure
    {
        [Offset(0UL)]
        public uint ResetCount { get => ReadHere<uint>(nameof(ResetCount)); set => WriteHere(nameof(ResetCount), value); }

        [Offset(4UL)]
        public uint StateCount { get => ReadHere<uint>(nameof(StateCount)); set => WriteHere(nameof(StateCount), value); }

        [Offset(8UL)]
        public uint DeepSleepCount { get => ReadHere<uint>(nameof(DeepSleepCount)); set => WriteHere(nameof(DeepSleepCount), value); }

        [Offset(16UL)]
        public ulong DripsWakeSkipCount { get => ReadHere<ulong>(nameof(DripsWakeSkipCount)); set => WriteHere(nameof(DripsWakeSkipCount), value); }

        [Offset(24UL)]
        public uint TimeUnit { get => ReadHere<uint>(nameof(TimeUnit)); set => WriteHere(nameof(TimeUnit), value); }

        [Offset(32UL)]
        public ulong StartTime { get => ReadHere<ulong>(nameof(StartTime)); set => WriteHere(nameof(StartTime), value); }

        [Offset(40UL)]
        [Length(1)]
        public DynamicArray State { get => ReadStructure<DynamicArray>(nameof(State)); set => WriteStructure(nameof(State), value); }

        public PlatformIdleAccounting(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PlatformIdleAccounting>();
        }
    }
}