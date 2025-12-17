using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PNP_REBALANCE_TRACE_CONTEXT")]
    public sealed class PnpRebalanceTraceContext : DynamicStructure
    {
        [Offset(0UL)]
        [Length(2)]
        public DynamicArray DeviceCount { get => ReadStructure<DynamicArray>(nameof(DeviceCount)); set => WriteStructure(nameof(DeviceCount), value); }

        [Offset(8UL)]
        public uint RebalancePhase { get => ReadHere<uint>(nameof(RebalancePhase)); set => WriteHere(nameof(RebalancePhase), value); }

        [Offset(12UL)]
        public uint Reason { get => ReadHere<uint>(nameof(Reason)); set => WriteHere(nameof(Reason), value); }

        [Offset(16UL)]
        [Length(2)]
        public DynamicArray Failure { get => ReadStructure<DynamicArray>(nameof(Failure)); set => WriteStructure(nameof(Failure), value); }

        [Offset(24UL)]
        [Length(2)]
        public DynamicArray SubtreeRoot { get => ReadStructure<DynamicArray>(nameof(SubtreeRoot)); set => WriteStructure(nameof(SubtreeRoot), value); }

        [Offset(40UL)]
        [Length(2)]
        public DynamicArray SubtreeIncludesRoot { get => ReadStructure<DynamicArray>(nameof(SubtreeIncludesRoot)); set => WriteStructure(nameof(SubtreeIncludesRoot), value); }

        [Offset(48UL)]
        public IntPtr TriggerRoot { get => ReadHere<IntPtr>(nameof(TriggerRoot)); set => WriteHere(nameof(TriggerRoot), value); }

        [Offset(56UL)]
        public PnpRebalanceFlags Flags { get => ReadStructure<PnpRebalanceFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(64UL)]
        [Length(2)]
        public DynamicArray BeginTime { get => ReadStructure<DynamicArray>(nameof(BeginTime)); set => WriteStructure(nameof(BeginTime), value); }

        [Offset(80UL)]
        [Length(2)]
        public DynamicArray VetoNode { get => ReadStructure<DynamicArray>(nameof(VetoNode)); set => WriteStructure(nameof(VetoNode), value); }

        [Offset(96UL)]
        [Length(2)]
        public DynamicArray VetoQueryRebalanceReason { get => ReadStructure<DynamicArray>(nameof(VetoQueryRebalanceReason)); set => WriteStructure(nameof(VetoQueryRebalanceReason), value); }

        [Offset(104UL)]
        public PnpResourceConflictTraceContext ConflictContext { get => ReadStructure<PnpResourceConflictTraceContext>(nameof(ConflictContext)); set => WriteStructure(nameof(ConflictContext), value); }

        public PnpRebalanceTraceContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PnpRebalanceTraceContext>();
        }
    }
}