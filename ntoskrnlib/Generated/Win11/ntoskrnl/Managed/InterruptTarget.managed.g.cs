using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_TARGET")]
    public sealed class InterruptTarget : DynamicStructure
    {
        [Offset(0UL)]
        public uint Target { get => ReadHere<uint>(nameof(Target)); set => WriteHere(nameof(Target), value); }

        [Offset(8UL)]
        public uint PhysicalTarget { get => ReadHere<uint>(nameof(PhysicalTarget)); set => WriteHere(nameof(PhysicalTarget), value); }

        [Offset(8UL)]
        public uint LogicalFlatTarget { get => ReadHere<uint>(nameof(LogicalFlatTarget)); set => WriteHere(nameof(LogicalFlatTarget), value); }

        [Offset(8UL)]
        public uint RemapIndex { get => ReadHere<uint>(nameof(RemapIndex)); set => WriteHere(nameof(RemapIndex), value); }

        [Offset(8UL)]
        public uint ClusterId { get => ReadHere<uint>(nameof(ClusterId)); set => WriteHere(nameof(ClusterId), value); }

        [Offset(12UL)]
        public uint ClusterMask { get => ReadHere<uint>(nameof(ClusterMask)); set => WriteHere(nameof(ClusterMask), value); }

        [Offset(8UL)]
        public UnnamedTag HypervisorTarget { get => ReadStructure<UnnamedTag>(nameof(HypervisorTarget)); set => WriteStructure(nameof(HypervisorTarget), value); }

        public InterruptTarget(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InterruptTarget>();
        }
    }
}