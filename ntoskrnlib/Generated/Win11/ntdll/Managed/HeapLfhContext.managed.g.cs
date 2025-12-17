using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HEAP_LFH_CONTEXT")]
    public sealed class HeapLfhContext : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr BackendCtx { get => ReadHere<IntPtr>(nameof(BackendCtx)); set => WriteHere(nameof(BackendCtx), value); }

        [Offset(8UL)]
        public HeapSuballocatorCallbacks Callbacks { get => ReadStructure<HeapSuballocatorCallbacks>(nameof(Callbacks)); set => WriteStructure(nameof(Callbacks), value); }

        [Offset(56UL)]
        public IntPtr AffinityModArray { get => ReadHere<IntPtr>(nameof(AffinityModArray)); set => WriteHere(nameof(AffinityModArray), value); }

        [Offset(64UL)]
        public byte MaxAffinity { get => ReadHere<byte>(nameof(MaxAffinity)); set => WriteHere(nameof(MaxAffinity), value); }

        [Offset(65UL)]
        public byte LockType { get => ReadHere<byte>(nameof(LockType)); set => WriteHere(nameof(LockType), value); }

        [Offset(66UL)]
        public short MemStatsOffset { get => ReadHere<short>(nameof(MemStatsOffset)); set => WriteHere(nameof(MemStatsOffset), value); }

        [Offset(68UL)]
        public HeapLfhConfig Config { get => ReadStructure<HeapLfhConfig>(nameof(Config)); set => WriteStructure(nameof(Config), value); }

        [Offset(76UL)]
        public uint TlsSlotIndex { get => ReadHere<uint>(nameof(TlsSlotIndex)); set => WriteHere(nameof(TlsSlotIndex), value); }

        [Offset(80UL)]
        public ulong EncodeKey { get => ReadHere<ulong>(nameof(EncodeKey)); set => WriteHere(nameof(EncodeKey), value); }

        [Offset(128UL)]
        public ulong ExtensionLock { get => ReadHere<ulong>(nameof(ExtensionLock)); set => WriteHere(nameof(ExtensionLock), value); }

        [Offset(136UL)]
        [Length(4)]
        public DynamicArray MetadataList { get => ReadStructure<DynamicArray>(nameof(MetadataList)); set => WriteStructure(nameof(MetadataList), value); }

        [Offset(192UL)]
        public HeapLfhHeatMap HeatMap { get => ReadStructure<HeapLfhHeatMap>(nameof(HeatMap)); set => WriteStructure(nameof(HeatMap), value); }

        [Offset(448UL)]
        [Length(128)]
        public DynamicArray Buckets { get => ReadStructure<DynamicArray>(nameof(Buckets)); set => WriteStructure(nameof(Buckets), value); }

        [Offset(1472UL)]
        [Length(1)]
        public DynamicArray SlotMaps { get => ReadStructure<DynamicArray>(nameof(SlotMaps)); set => WriteStructure(nameof(SlotMaps), value); }

        public HeapLfhContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapLfhContext>();
        }
    }
}