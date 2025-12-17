using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_ACCESS_LOG_STATE")]
    public sealed class MiAccessLogState : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr CcAccessLog { get => ReadHere<IntPtr>(nameof(CcAccessLog)); set => WriteHere(nameof(CcAccessLog), value); }

        [Offset(8UL)]
        public WorkQueueItem DisableAccessLoggingWorkItem { get => ReadStructure<WorkQueueItem>(nameof(DisableAccessLoggingWorkItem)); set => WriteStructure(nameof(DisableAccessLoggingWorkItem), value); }

        [Offset(40UL)]
        public uint DisableAccessLoggingState { get => ReadHere<uint>(nameof(DisableAccessLoggingState)); set => WriteHere(nameof(DisableAccessLoggingState), value); }

        [Offset(44UL)]
        public uint Enabled { get => ReadHere<uint>(nameof(Enabled)); set => WriteHere(nameof(Enabled), value); }

        [Offset(48UL)]
        public uint MinLoggingPriority { get => ReadHere<uint>(nameof(MinLoggingPriority)); set => WriteHere(nameof(MinLoggingPriority), value); }

        [Offset(56UL)]
        public IntPtr PfnRepurposeLog { get => ReadHere<IntPtr>(nameof(PfnRepurposeLog)); set => WriteHere(nameof(PfnRepurposeLog), value); }

        [Offset(64UL)]
        public Kdpc AllocatePfnRepurposeDpc { get => ReadStructure<Kdpc>(nameof(AllocatePfnRepurposeDpc)); set => WriteStructure(nameof(AllocatePfnRepurposeDpc), value); }

        [Offset(128UL)]
        public int AccessLoggingLock { get => ReadHere<int>(nameof(AccessLoggingLock)); set => WriteHere(nameof(AccessLoggingLock), value); }

        public MiAccessLogState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiAccessLogState>();
        }
    }
}