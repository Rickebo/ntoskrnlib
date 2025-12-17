using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROCESS_EXECUTION_STATE")]
    public sealed class ProcessExecutionState : DynamicStructure
    {
        [Offset(0UL)]
        public sbyte State { get => ReadHere<sbyte>(nameof(State)); set => WriteHere(nameof(State), value); }

        [Offset(0UL)]
        public byte ProcessFrozen { get => ReadHere<byte>(nameof(ProcessFrozen)); set => WriteHere(nameof(ProcessFrozen), value); }

        [Offset(0UL)]
        public byte ProcessSwapped { get => ReadHere<byte>(nameof(ProcessSwapped)); set => WriteHere(nameof(ProcessSwapped), value); }

        [Offset(0UL)]
        public byte ProcessGraphicsFreezeOptimized { get => ReadHere<byte>(nameof(ProcessGraphicsFreezeOptimized)); set => WriteHere(nameof(ProcessGraphicsFreezeOptimized), value); }

        [Offset(0UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public ProcessExecutionState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcessExecutionState>();
        }
    }
}