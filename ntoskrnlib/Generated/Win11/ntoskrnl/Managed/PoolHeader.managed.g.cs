using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POOL_HEADER")]
    public sealed class PoolHeader : DynamicStructure
    {
        [Offset(0UL)]
        public ushort PreviousSize { get => ReadHere<ushort>(nameof(PreviousSize)); set => WriteHere(nameof(PreviousSize), value); }

        [Offset(0UL)]
        public ushort PoolIndex { get => ReadHere<ushort>(nameof(PoolIndex)); set => WriteHere(nameof(PoolIndex), value); }

        [Offset(2UL)]
        public ushort BlockSize { get => ReadHere<ushort>(nameof(BlockSize)); set => WriteHere(nameof(BlockSize), value); }

        [Offset(2UL)]
        public ushort PoolType { get => ReadHere<ushort>(nameof(PoolType)); set => WriteHere(nameof(PoolType), value); }

        [Offset(0UL)]
        public uint Ulong1 { get => ReadHere<uint>(nameof(Ulong1)); set => WriteHere(nameof(Ulong1), value); }

        [Offset(4UL)]
        public uint PoolTag { get => ReadHere<uint>(nameof(PoolTag)); set => WriteHere(nameof(PoolTag), value); }

        [Offset(8UL)]
        public IntPtr ProcessBilled { get => ReadHere<IntPtr>(nameof(ProcessBilled)); set => WriteHere(nameof(ProcessBilled), value); }

        [Offset(8UL)]
        public ushort AllocatorBackTraceIndex { get => ReadHere<ushort>(nameof(AllocatorBackTraceIndex)); set => WriteHere(nameof(AllocatorBackTraceIndex), value); }

        [Offset(10UL)]
        public ushort PoolTagHash { get => ReadHere<ushort>(nameof(PoolTagHash)); set => WriteHere(nameof(PoolTagHash), value); }

        public PoolHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PoolHeader>();
        }
    }
}