using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SEP_CACHED_HANDLES_ENTRY")]
    public sealed class SepCachedHandlesEntry : DynamicStructure
    {
        [Offset(0UL)]
        public RtlDynamicHashTableEntry HashEntry { get => ReadStructure<RtlDynamicHashTableEntry>(nameof(HashEntry)); set => WriteStructure(nameof(HashEntry), value); }

        [Offset(24UL)]
        public long ReferenceCount { get => ReadHere<long>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(32UL)]
        public SepCachedHandlesEntryDescriptor EntryDescriptor { get => ReadStructure<SepCachedHandlesEntryDescriptor>(nameof(EntryDescriptor)); set => WriteStructure(nameof(EntryDescriptor), value); }

        [Offset(56UL)]
        public uint HandleCount { get => ReadHere<uint>(nameof(HandleCount)); set => WriteHere(nameof(HandleCount), value); }

        [Offset(64UL)]
        public IntPtr Handles { get => ReadHere<IntPtr>(nameof(Handles)); set => WriteHere(nameof(Handles), value); }

        public SepCachedHandlesEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SepCachedHandlesEntry>();
        }
    }
}