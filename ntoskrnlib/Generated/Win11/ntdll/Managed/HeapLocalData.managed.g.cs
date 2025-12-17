using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_LOCAL_DATA")]
    public sealed class HeapLocalData : DynamicStructure
    {
        [Offset(0UL)]
        public SlistHeader DeletedSubSegments { get => ReadStructure<SlistHeader>(nameof(DeletedSubSegments)); set => WriteStructure(nameof(DeletedSubSegments), value); }

        [Offset(16UL)]
        public IntPtr CrtZone { get => ReadHere<IntPtr>(nameof(CrtZone)); set => WriteHere(nameof(CrtZone), value); }

        [Offset(24UL)]
        public IntPtr LowFragHeap { get => ReadHere<IntPtr>(nameof(LowFragHeap)); set => WriteHere(nameof(LowFragHeap), value); }

        [Offset(32UL)]
        public uint Sequence { get => ReadHere<uint>(nameof(Sequence)); set => WriteHere(nameof(Sequence), value); }

        [Offset(36UL)]
        public uint DeleteRateThreshold { get => ReadHere<uint>(nameof(DeleteRateThreshold)); set => WriteHere(nameof(DeleteRateThreshold), value); }

        public HeapLocalData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLocalData>();
        }
    }
}