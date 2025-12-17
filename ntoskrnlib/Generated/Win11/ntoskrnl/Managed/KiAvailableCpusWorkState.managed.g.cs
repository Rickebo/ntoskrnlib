using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KI_AVAILABLE_CPUS_WORK_STATE")]
    public sealed class KiAvailableCpusWorkState : DynamicStructure
    {
        [Offset(0UL)]
        public uint WorkerExecuting { get => ReadHere<uint>(nameof(WorkerExecuting)); set => WriteHere(nameof(WorkerExecuting), value); }

        [Offset(0UL)]
        public uint WorkPresent { get => ReadHere<uint>(nameof(WorkPresent)); set => WriteHere(nameof(WorkPresent), value); }

        [Offset(0UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public uint AllFields { get => ReadHere<uint>(nameof(AllFields)); set => WriteHere(nameof(AllFields), value); }

        public KiAvailableCpusWorkState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KiAvailableCpusWorkState>();
        }
    }
}