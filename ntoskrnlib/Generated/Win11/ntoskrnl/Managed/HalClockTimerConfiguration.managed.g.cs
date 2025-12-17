using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HAL_CLOCK_TIMER_CONFIGURATION")]
    public sealed class HalClockTimerConfiguration : DynamicStructure
    {
        [Offset(0UL)]
        public byte Flags { get => ReadHere<byte>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(0UL)]
        public byte AlwaysOnTimer { get => ReadHere<byte>(nameof(AlwaysOnTimer)); set => WriteHere(nameof(AlwaysOnTimer), value); }

        [Offset(0UL)]
        public byte HighLatency { get => ReadHere<byte>(nameof(HighLatency)); set => WriteHere(nameof(HighLatency), value); }

        [Offset(0UL)]
        public byte PerCpuTimer { get => ReadHere<byte>(nameof(PerCpuTimer)); set => WriteHere(nameof(PerCpuTimer), value); }

        [Offset(0UL)]
        public byte DynamicTickSupported { get => ReadHere<byte>(nameof(DynamicTickSupported)); set => WriteHere(nameof(DynamicTickSupported), value); }

        [Offset(4UL)]
        public uint KnownType { get => ReadHere<uint>(nameof(KnownType)); set => WriteHere(nameof(KnownType), value); }

        [Offset(8UL)]
        public uint Capabilities { get => ReadHere<uint>(nameof(Capabilities)); set => WriteHere(nameof(Capabilities), value); }

        [Offset(16UL)]
        public ulong MaxIncrement { get => ReadHere<ulong>(nameof(MaxIncrement)); set => WriteHere(nameof(MaxIncrement), value); }

        [Offset(24UL)]
        public uint MinIncrement { get => ReadHere<uint>(nameof(MinIncrement)); set => WriteHere(nameof(MinIncrement), value); }

        public HalClockTimerConfiguration(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalClockTimerConfiguration>();
        }
    }
}