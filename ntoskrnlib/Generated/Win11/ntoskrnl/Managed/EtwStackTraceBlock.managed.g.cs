using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_STACK_TRACE_BLOCK")]
    public sealed class EtwStackTraceBlock : DynamicStructure
    {
        [Offset(0UL)]
        public EtwApcPool ApcPool { get => ReadStructure<EtwApcPool>(nameof(ApcPool)); set => WriteStructure(nameof(ApcPool), value); }

        [Offset(192UL)]
        public int StackCaptureAttemptCount { get => ReadHere<int>(nameof(StackCaptureAttemptCount)); set => WriteHere(nameof(StackCaptureAttemptCount), value); }

        [Offset(196UL)]
        public int StackExpansionFailureCount { get => ReadHere<int>(nameof(StackExpansionFailureCount)); set => WriteHere(nameof(StackExpansionFailureCount), value); }

        public EtwStackTraceBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwStackTraceBlock>();
        }
    }
}