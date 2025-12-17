using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SEP_LUID_TO_INDEX_MAP_ENTRY")]
    public sealed class SepLuidToIndexMapEntry : DynamicStructure
    {
        [Offset(0UL)]
        public RtlDynamicHashTableEntry HashEntry { get => ReadStructure<RtlDynamicHashTableEntry>(nameof(HashEntry)); set => WriteStructure(nameof(HashEntry), value); }

        [Offset(24UL)]
        public long ReferenceCount { get => ReadHere<long>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(32UL)]
        public ulong Luid { get => ReadHere<ulong>(nameof(Luid)); set => WriteHere(nameof(Luid), value); }

        [Offset(40UL)]
        public ulong IndexIntoGlobalSingletonTable { get => ReadHere<ulong>(nameof(IndexIntoGlobalSingletonTable)); set => WriteHere(nameof(IndexIntoGlobalSingletonTable), value); }

        [Offset(48UL)]
        public byte MarkedForDeletion { get => ReadHere<byte>(nameof(MarkedForDeletion)); set => WriteHere(nameof(MarkedForDeletion), value); }

        public SepLuidToIndexMapEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SepLuidToIndexMapEntry>();
        }
    }
}