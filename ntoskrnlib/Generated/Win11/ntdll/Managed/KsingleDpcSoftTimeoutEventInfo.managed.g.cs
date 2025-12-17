using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KSINGLE_DPC_SOFT_TIMEOUT_EVENT_INFO")]
    public sealed class KsingleDpcSoftTimeoutEventInfo : DynamicStructure
    {
        [Offset(0UL)]
        public Kdpc EventDpc { get => ReadStructure<Kdpc>(nameof(EventDpc)); set => WriteStructure(nameof(EventDpc), value); }

        [Offset(64UL)]
        public IntPtr DeferredRoutine { get => ReadHere<IntPtr>(nameof(DeferredRoutine)); set => WriteHere(nameof(DeferredRoutine), value); }

        [Offset(72UL)]
        public uint TickCount { get => ReadHere<uint>(nameof(TickCount)); set => WriteHere(nameof(TickCount), value); }

        public KsingleDpcSoftTimeoutEventInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KsingleDpcSoftTimeoutEventInfo>();
        }
    }
}