using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_NODE_AFFINITY_INFORMATION")]
    public sealed class MiSystemNodeAffinityInformation : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr GroupAffinity { get => ReadHere<IntPtr>(nameof(GroupAffinity)); set => WriteHere(nameof(GroupAffinity), value); }

        [Offset(8UL)]
        public uint NumberOfDomains { get => ReadHere<uint>(nameof(NumberOfDomains)); set => WriteHere(nameof(NumberOfDomains), value); }

        [Offset(12UL)]
        public uint GlobalDomainIndex { get => ReadHere<uint>(nameof(GlobalDomainIndex)); set => WriteHere(nameof(GlobalDomainIndex), value); }

        [Offset(16UL)]
        public ushort GroupAffinityCount { get => ReadHere<ushort>(nameof(GroupAffinityCount)); set => WriteHere(nameof(GroupAffinityCount), value); }

        [Offset(18UL)]
        [Length(3)]
        public DynamicArray ProcessorCount { get => ReadStructure<DynamicArray>(nameof(ProcessorCount)); set => WriteStructure(nameof(ProcessorCount), value); }

        [Offset(24UL)]
        [Length(3)]
        public DynamicArray UsableProcessorCount { get => ReadStructure<DynamicArray>(nameof(UsableProcessorCount)); set => WriteStructure(nameof(UsableProcessorCount), value); }

        public MiSystemNodeAffinityInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSystemNodeAffinityInformation>();
        }
    }
}