using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KPROCESS_AVAILABLE_CPU_STATE")]
    public sealed class KprocessAvailableCpuState : DynamicStructure
    {
        [Offset(0UL)]
        public RtlTickLock SequenceNumber { get => ReadStructure<RtlTickLock>(nameof(SequenceNumber)); set => WriteStructure(nameof(SequenceNumber), value); }

        [Offset(8UL)]
        public ulong CpuSetSequenceNumber { get => ReadHere<ulong>(nameof(CpuSetSequenceNumber)); set => WriteHere(nameof(CpuSetSequenceNumber), value); }

        [Offset(16UL)]
        public ulong ForceParkSequenceNumber { get => ReadHere<ulong>(nameof(ForceParkSequenceNumber)); set => WriteHere(nameof(ForceParkSequenceNumber), value); }

        [Offset(24UL)]
        public IntPtr Affinity { get => ReadHere<IntPtr>(nameof(Affinity)); set => WriteHere(nameof(Affinity), value); }

        [Offset(32UL)]
        public ExPushLock SubscriptionLock { get => ReadStructure<ExPushLock>(nameof(SubscriptionLock)); set => WriteStructure(nameof(SubscriptionLock), value); }

        [Offset(40UL)]
        public ListEntry SubscriptionList { get => ReadStructure<ListEntry>(nameof(SubscriptionList)); set => WriteStructure(nameof(SubscriptionList), value); }

        [Offset(56UL)]
        public KiAvailableCpusWorkItem WorkItem { get => ReadStructure<KiAvailableCpusWorkItem>(nameof(WorkItem)); set => WriteStructure(nameof(WorkItem), value); }

        public KprocessAvailableCpuState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KprocessAvailableCpuState>();
        }
    }
}