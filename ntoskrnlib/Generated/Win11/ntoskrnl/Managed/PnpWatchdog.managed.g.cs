using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PNP_WATCHDOG")]
    public sealed class PnpWatchdog : DynamicStructure
    {
        [Offset(0UL)]
        public ulong WatchdogStart { get => ReadHere<ulong>(nameof(WatchdogStart)); set => WriteHere(nameof(WatchdogStart), value); }

        [Offset(8UL)]
        public IntPtr WatchdogTimer { get => ReadHere<IntPtr>(nameof(WatchdogTimer)); set => WriteHere(nameof(WatchdogTimer), value); }

        [Offset(16UL)]
        public uint WatchdogContextType { get => ReadHere<uint>(nameof(WatchdogContextType)); set => WriteHere(nameof(WatchdogContextType), value); }

        [Offset(24UL)]
        public IntPtr WatchdogContext { get => ReadHere<IntPtr>(nameof(WatchdogContext)); set => WriteHere(nameof(WatchdogContext), value); }

        [Offset(32UL)]
        public byte FirstChanceTriggered { get => ReadHere<byte>(nameof(FirstChanceTriggered)); set => WriteHere(nameof(FirstChanceTriggered), value); }

        [Offset(33UL)]
        public byte TelemetryGenerated { get => ReadHere<byte>(nameof(TelemetryGenerated)); set => WriteHere(nameof(TelemetryGenerated), value); }

        [Offset(40UL)]
        public UnicodeString DriverToBlame { get => ReadStructure<UnicodeString>(nameof(DriverToBlame)); set => WriteStructure(nameof(DriverToBlame), value); }

        [Offset(56UL)]
        [Length(1)]
        public DynamicArray DriverToBlameBuffer { get => ReadStructure<DynamicArray>(nameof(DriverToBlameBuffer)); set => WriteStructure(nameof(DriverToBlameBuffer), value); }

        public PnpWatchdog(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PnpWatchdog>();
        }
    }
}