using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LAZY_WRITER")]
    public sealed class LazyWriter : DynamicStructure
    {
        [Offset(0UL)]
        public Ktimer ScanTimer { get => ReadStructure<Ktimer>(nameof(ScanTimer)); set => WriteStructure(nameof(ScanTimer), value); }

        [Offset(64UL)]
        public byte TimerInitialized { get => ReadHere<byte>(nameof(TimerInitialized)); set => WriteHere(nameof(TimerInitialized), value); }

        [Offset(65UL)]
        public byte ScanActive { get => ReadHere<byte>(nameof(ScanActive)); set => WriteHere(nameof(ScanActive), value); }

        [Offset(66UL)]
        public byte OtherWork { get => ReadHere<byte>(nameof(OtherWork)); set => WriteHere(nameof(OtherWork), value); }

        [Offset(67UL)]
        public byte PendingTeardownScan { get => ReadHere<byte>(nameof(PendingTeardownScan)); set => WriteHere(nameof(PendingTeardownScan), value); }

        [Offset(68UL)]
        public byte PendingPeriodicScan { get => ReadHere<byte>(nameof(PendingPeriodicScan)); set => WriteHere(nameof(PendingPeriodicScan), value); }

        [Offset(69UL)]
        public byte PendingLowMemoryScan { get => ReadHere<byte>(nameof(PendingLowMemoryScan)); set => WriteHere(nameof(PendingLowMemoryScan), value); }

        [Offset(70UL)]
        public byte PendingPowerScan { get => ReadHere<byte>(nameof(PendingPowerScan)); set => WriteHere(nameof(PendingPowerScan), value); }

        [Offset(71UL)]
        public byte PendingCoalescingFlushScan { get => ReadHere<byte>(nameof(PendingCoalescingFlushScan)); set => WriteHere(nameof(PendingCoalescingFlushScan), value); }

        public LazyWriter(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LazyWriter>();
        }
    }
}