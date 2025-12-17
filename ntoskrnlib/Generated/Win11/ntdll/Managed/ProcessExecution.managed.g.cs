using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PROCESS_EXECUTION")]
    public sealed class ProcessExecution : DynamicStructure
    {
        [Offset(0UL)]
        public int State { get => ReadHere<int>(nameof(State)); set => WriteHere(nameof(State), value); }

        [Offset(0UL)]
        public ProcessExecutionTransition Transition { get => ReadStructure<ProcessExecutionTransition>(nameof(Transition)); set => WriteStructure(nameof(Transition), value); }

        [Offset(2UL)]
        public ProcessExecutionState Current { get => ReadStructure<ProcessExecutionState>(nameof(Current)); set => WriteStructure(nameof(Current), value); }

        [Offset(3UL)]
        public ProcessExecutionState Requested { get => ReadStructure<ProcessExecutionState>(nameof(Requested)); set => WriteStructure(nameof(Requested), value); }

        public ProcessExecution(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcessExecution>();
        }
    }
}