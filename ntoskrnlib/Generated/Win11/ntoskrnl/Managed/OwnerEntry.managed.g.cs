using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OWNER_ENTRY")]
    public sealed class OwnerEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ulong OwnerThread { get => ReadHere<ulong>(nameof(OwnerThread)); set => WriteHere(nameof(OwnerThread), value); }

        [Offset(8UL)]
        public uint IoPriorityBoosted { get => ReadHere<uint>(nameof(IoPriorityBoosted)); set => WriteHere(nameof(IoPriorityBoosted), value); }

        [Offset(8UL)]
        public uint OwnerReferenced { get => ReadHere<uint>(nameof(OwnerReferenced)); set => WriteHere(nameof(OwnerReferenced), value); }

        [Offset(8UL)]
        public uint IoQoSPriorityBoosted { get => ReadHere<uint>(nameof(IoQoSPriorityBoosted)); set => WriteHere(nameof(IoQoSPriorityBoosted), value); }

        [Offset(8UL)]
        public uint OwnerCount { get => ReadHere<uint>(nameof(OwnerCount)); set => WriteHere(nameof(OwnerCount), value); }

        [Offset(8UL)]
        public uint TableSize { get => ReadHere<uint>(nameof(TableSize)); set => WriteHere(nameof(TableSize), value); }

        public OwnerEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<OwnerEntry>();
        }
    }
}