using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_PARTITION_CONTEXT")]
    public sealed class EtwPartitionContext : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Partition { get => ReadHere<IntPtr>(nameof(Partition)); set => WriteHere(nameof(Partition), value); }

        public EtwPartitionContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwPartitionContext>();
        }
    }
}