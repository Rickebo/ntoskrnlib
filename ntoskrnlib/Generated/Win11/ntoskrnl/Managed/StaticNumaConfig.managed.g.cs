using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_STATIC_NUMA_CONFIG")]
    public sealed class StaticNumaConfig : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ProcessorLocalId { get => ReadHere<IntPtr>(nameof(ProcessorLocalId)); set => WriteHere(nameof(ProcessorLocalId), value); }

        [Offset(8UL)]
        public IntPtr ProcessorUid { get => ReadHere<IntPtr>(nameof(ProcessorUid)); set => WriteHere(nameof(ProcessorUid), value); }

        [Offset(16UL)]
        public IntPtr ProcessorProximity { get => ReadHere<IntPtr>(nameof(ProcessorProximity)); set => WriteHere(nameof(ProcessorProximity), value); }

        [Offset(24UL)]
        public IntPtr ProximityId { get => ReadHere<IntPtr>(nameof(ProximityId)); set => WriteHere(nameof(ProximityId), value); }

        [Offset(32UL)]
        public IntPtr OrigProximityId { get => ReadHere<IntPtr>(nameof(OrigProximityId)); set => WriteHere(nameof(OrigProximityId), value); }

        [Offset(40UL)]
        public IntPtr NodeCapacity { get => ReadHere<IntPtr>(nameof(NodeCapacity)); set => WriteHere(nameof(NodeCapacity), value); }

        [Offset(48UL)]
        public IntPtr NodeDistance { get => ReadHere<IntPtr>(nameof(NodeDistance)); set => WriteHere(nameof(NodeDistance), value); }

        [Offset(56UL)]
        public uint NodeCount { get => ReadHere<uint>(nameof(NodeCount)); set => WriteHere(nameof(NodeCount), value); }

        [Offset(60UL)]
        public uint ProcessorCount { get => ReadHere<uint>(nameof(ProcessorCount)); set => WriteHere(nameof(ProcessorCount), value); }

        [Offset(64UL)]
        public uint AllocatedNodeCount { get => ReadHere<uint>(nameof(AllocatedNodeCount)); set => WriteHere(nameof(AllocatedNodeCount), value); }

        [Offset(68UL)]
        public uint AllocatedProcCount { get => ReadHere<uint>(nameof(AllocatedProcCount)); set => WriteHere(nameof(AllocatedProcCount), value); }

        public StaticNumaConfig(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<StaticNumaConfig>();
        }
    }
}