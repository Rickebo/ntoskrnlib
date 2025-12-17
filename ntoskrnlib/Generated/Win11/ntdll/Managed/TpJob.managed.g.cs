using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TP_JOB")]
    public sealed class TpJob : DynamicStructure
    {
        [Offset(0UL)]
        public TpDirect Direct { get => ReadStructure<TpDirect>(nameof(Direct)); set => WriteStructure(nameof(Direct), value); }

        [Offset(72UL)]
        public TppCleanupGroupMember CleanupGroupMember { get => ReadStructure<TppCleanupGroupMember>(nameof(CleanupGroupMember)); set => WriteStructure(nameof(CleanupGroupMember), value); }

        [Offset(272UL)]
        public IntPtr JobHandle { get => ReadHere<IntPtr>(nameof(JobHandle)); set => WriteHere(nameof(JobHandle), value); }

        [Offset(280UL)]
        public long CompletionState { get => ReadHere<long>(nameof(CompletionState)); set => WriteHere(nameof(CompletionState), value); }

        [Offset(280UL)]
        public long Rundown { get => ReadHere<long>(nameof(Rundown)); set => WriteHere(nameof(Rundown), value); }

        [Offset(280UL)]
        public long CompletionCount { get => ReadHere<long>(nameof(CompletionCount)); set => WriteHere(nameof(CompletionCount), value); }

        [Offset(288UL)]
        public RtlSrwlock RundownLock { get => ReadStructure<RtlSrwlock>(nameof(RundownLock)); set => WriteStructure(nameof(RundownLock), value); }

        public TpJob(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TpJob>();
        }
    }
}