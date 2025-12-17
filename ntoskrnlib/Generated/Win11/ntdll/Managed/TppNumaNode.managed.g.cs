using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TPP_NUMA_NODE")]
    public sealed class TppNumaNode : DynamicStructure
    {
        [Offset(0UL)]
        public int WorkerCount { get => ReadHere<int>(nameof(WorkerCount)); set => WriteHere(nameof(WorkerCount), value); }

        public TppNumaNode(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TppNumaNode>();
        }
    }
}