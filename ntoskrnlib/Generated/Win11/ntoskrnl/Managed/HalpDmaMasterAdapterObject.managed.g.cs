using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HALP_DMA_MASTER_ADAPTER_OBJECT")]
    public sealed class HalpDmaMasterAdapterObject : DynamicStructure
    {
        [Offset(0UL)]
        public HalpDmaAdapterObject AdapterObject { get => ReadStructure<HalpDmaAdapterObject>(nameof(AdapterObject)); set => WriteStructure(nameof(AdapterObject), value); }

        [Offset(160UL)]
        public ulong QueueLock { get => ReadHere<ulong>(nameof(QueueLock)); set => WriteHere(nameof(QueueLock), value); }

        [Offset(168UL)]
        public ListEntry ContiguousAdapterQueue { get => ReadStructure<ListEntry>(nameof(ContiguousAdapterQueue)); set => WriteStructure(nameof(ContiguousAdapterQueue), value); }

        [Offset(184UL)]
        public ListEntry ScatterAdapterQueue { get => ReadStructure<ListEntry>(nameof(ScatterAdapterQueue)); set => WriteStructure(nameof(ScatterAdapterQueue), value); }

        [Offset(200UL)]
        public uint MapBufferSize { get => ReadHere<uint>(nameof(MapBufferSize)); set => WriteHere(nameof(MapBufferSize), value); }

        [Offset(208UL)]
        public LargeInteger MapBufferPhysicalAddress { get => ReadStructure<LargeInteger>(nameof(MapBufferPhysicalAddress)); set => WriteStructure(nameof(MapBufferPhysicalAddress), value); }

        [Offset(216UL)]
        public uint ContiguousPageCount { get => ReadHere<uint>(nameof(ContiguousPageCount)); set => WriteHere(nameof(ContiguousPageCount), value); }

        [Offset(220UL)]
        public uint ContiguousPageLimit { get => ReadHere<uint>(nameof(ContiguousPageLimit)); set => WriteHere(nameof(ContiguousPageLimit), value); }

        [Offset(224UL)]
        public uint ScatterPageCount { get => ReadHere<uint>(nameof(ScatterPageCount)); set => WriteHere(nameof(ScatterPageCount), value); }

        [Offset(228UL)]
        public uint ScatterPageLimit { get => ReadHere<uint>(nameof(ScatterPageLimit)); set => WriteHere(nameof(ScatterPageLimit), value); }

        public HalpDmaMasterAdapterObject(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalpDmaMasterAdapterObject>();
        }
    }
}