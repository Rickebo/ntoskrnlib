using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_WORK_ORDER_WATCHDOG_INFO")]
    public sealed class PopFxWorkOrderWatchdogInfo : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Link { get => ReadStructure<ListEntry>(nameof(Link)); set => WriteStructure(nameof(Link), value); }

        [Offset(16UL)]
        public Ktimer Timer { get => ReadStructure<Ktimer>(nameof(Timer)); set => WriteStructure(nameof(Timer), value); }

        [Offset(80UL)]
        public Kdpc Dpc { get => ReadStructure<Kdpc>(nameof(Dpc)); set => WriteStructure(nameof(Dpc), value); }

        [Offset(144UL)]
        public IntPtr WorkOrder { get => ReadHere<IntPtr>(nameof(WorkOrder)); set => WriteHere(nameof(WorkOrder), value); }

        [Offset(152UL)]
        public IntPtr CurrentWorkInfo { get => ReadHere<IntPtr>(nameof(CurrentWorkInfo)); set => WriteHere(nameof(CurrentWorkInfo), value); }

        [Offset(160UL)]
        public ulong WatchdogStart { get => ReadHere<ulong>(nameof(WatchdogStart)); set => WriteHere(nameof(WatchdogStart), value); }

        [Offset(168UL)]
        public IntPtr WorkerThread { get => ReadHere<IntPtr>(nameof(WorkerThread)); set => WriteHere(nameof(WorkerThread), value); }

        public PopFxWorkOrderWatchdogInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxWorkOrderWatchdogInfo>();
        }
    }
}