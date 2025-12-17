using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_USER_MEMORY_CACHE_ENTRY")]
    public sealed class UserMemoryCacheEntry : DynamicStructure
    {
        [Offset(0UL)]
        public SlistHeader UserBlocks { get => ReadStructure<SlistHeader>(nameof(UserBlocks)); set => WriteStructure(nameof(UserBlocks), value); }

        [Offset(16UL)]
        public uint AvailableBlocks { get => ReadHere<uint>(nameof(AvailableBlocks)); set => WriteHere(nameof(AvailableBlocks), value); }

        [Offset(20UL)]
        public uint MinimumDepth { get => ReadHere<uint>(nameof(MinimumDepth)); set => WriteHere(nameof(MinimumDepth), value); }

        [Offset(24UL)]
        public uint CacheShiftThreshold { get => ReadHere<uint>(nameof(CacheShiftThreshold)); set => WriteHere(nameof(CacheShiftThreshold), value); }

        [Offset(28UL)]
        public ushort Allocations { get => ReadHere<ushort>(nameof(Allocations)); set => WriteHere(nameof(Allocations), value); }

        [Offset(30UL)]
        public ushort Frees { get => ReadHere<ushort>(nameof(Frees)); set => WriteHere(nameof(Frees), value); }

        [Offset(32UL)]
        public ushort CacheHits { get => ReadHere<ushort>(nameof(CacheHits)); set => WriteHere(nameof(CacheHits), value); }

        public UserMemoryCacheEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<UserMemoryCacheEntry>();
        }
    }
}