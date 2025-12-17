using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_DPH_HEAP_BLOCK")]
    public sealed class DphHeapBlock : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr pNextAlloc { get => ReadHere<IntPtr>(nameof(pNextAlloc)); set => WriteHere(nameof(pNextAlloc), value); }

        [Offset(0UL)]
        public ListEntry AvailableEntry { get => ReadStructure<ListEntry>(nameof(AvailableEntry)); set => WriteStructure(nameof(AvailableEntry), value); }

        [Offset(0UL)]
        public RtlBalancedLinks TableLinks { get => ReadStructure<RtlBalancedLinks>(nameof(TableLinks)); set => WriteStructure(nameof(TableLinks), value); }

        [Offset(32UL)]
        public IntPtr pUserAllocation { get => ReadHere<IntPtr>(nameof(pUserAllocation)); set => WriteHere(nameof(pUserAllocation), value); }

        [Offset(40UL)]
        public IntPtr pVirtualBlock { get => ReadHere<IntPtr>(nameof(pVirtualBlock)); set => WriteHere(nameof(pVirtualBlock), value); }

        [Offset(48UL)]
        public ulong nVirtualBlockSize { get => ReadHere<ulong>(nameof(nVirtualBlockSize)); set => WriteHere(nameof(nVirtualBlockSize), value); }

        [Offset(56UL)]
        public ulong nVirtualAccessSize { get => ReadHere<ulong>(nameof(nVirtualAccessSize)); set => WriteHere(nameof(nVirtualAccessSize), value); }

        [Offset(64UL)]
        public ulong nUserRequestedSize { get => ReadHere<ulong>(nameof(nUserRequestedSize)); set => WriteHere(nameof(nUserRequestedSize), value); }

        [Offset(72UL)]
        public ulong nUserActualSize { get => ReadHere<ulong>(nameof(nUserActualSize)); set => WriteHere(nameof(nUserActualSize), value); }

        [Offset(80UL)]
        public IntPtr UserValue { get => ReadHere<IntPtr>(nameof(UserValue)); set => WriteHere(nameof(UserValue), value); }

        [Offset(88UL)]
        public uint UserFlags { get => ReadHere<uint>(nameof(UserFlags)); set => WriteHere(nameof(UserFlags), value); }

        [Offset(96UL)]
        public IntPtr StackTrace { get => ReadHere<IntPtr>(nameof(StackTrace)); set => WriteHere(nameof(StackTrace), value); }

        [Offset(104UL)]
        public ListEntry AdjacencyEntry { get => ReadStructure<ListEntry>(nameof(AdjacencyEntry)); set => WriteStructure(nameof(AdjacencyEntry), value); }

        [Offset(120UL)]
        public IntPtr pVirtualRegion { get => ReadHere<IntPtr>(nameof(pVirtualRegion)); set => WriteHere(nameof(pVirtualRegion), value); }

        public DphHeapBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DphHeapBlock>();
        }
    }
}