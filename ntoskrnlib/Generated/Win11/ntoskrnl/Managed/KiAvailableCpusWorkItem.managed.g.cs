using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KI_AVAILABLE_CPUS_WORK_ITEM")]
    public sealed class KiAvailableCpusWorkItem : DynamicStructure
    {
        [Offset(0UL)]
        public WorkQueueItem ExWorkItem { get => ReadStructure<WorkQueueItem>(nameof(ExWorkItem)); set => WriteStructure(nameof(ExWorkItem), value); }

        [Offset(32UL)]
        public ExRundownRef RundownRef { get => ReadStructure<ExRundownRef>(nameof(RundownRef)); set => WriteStructure(nameof(RundownRef), value); }

        [Offset(40UL)]
        public KiAvailableCpusWorkState WorkState { get => ReadStructure<KiAvailableCpusWorkState>(nameof(WorkState)); set => WriteStructure(nameof(WorkState), value); }

        [Offset(48UL)]
        public IntPtr Callback { get => ReadHere<IntPtr>(nameof(Callback)); set => WriteHere(nameof(Callback), value); }

        [Offset(56UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        public KiAvailableCpusWorkItem(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KiAvailableCpusWorkItem>();
        }
    }
}