using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PROCESS_EXECUTION_TRANSITION")]
    public sealed class ProcessExecutionTransition : DynamicStructure
    {
        [Offset(0UL)]
        public short TransitionState { get => ReadHere<short>(nameof(TransitionState)); set => WriteHere(nameof(TransitionState), value); }

        [Offset(0UL)]
        public ushort InProgress { get => ReadHere<ushort>(nameof(InProgress)); set => WriteHere(nameof(InProgress), value); }

        [Offset(0UL)]
        public ushort Reserved { get => ReadHere<ushort>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public ProcessExecutionTransition(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcessExecutionTransition>();
        }
    }
}