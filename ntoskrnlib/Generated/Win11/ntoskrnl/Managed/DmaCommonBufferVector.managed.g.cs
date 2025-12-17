using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DMA_COMMON_BUFFER_VECTOR")]
    public sealed class DmaCommonBufferVector : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public ulong SizeOfEntries { get => ReadHere<ulong>(nameof(SizeOfEntries)); set => WriteHere(nameof(SizeOfEntries), value); }

        [Offset(24UL)]
        public uint NumberOfEntries { get => ReadHere<uint>(nameof(NumberOfEntries)); set => WriteHere(nameof(NumberOfEntries), value); }

        [Offset(32UL)]
        public IntPtr Domain { get => ReadHere<IntPtr>(nameof(Domain)); set => WriteHere(nameof(Domain), value); }

        [Offset(40UL)]
        public IntPtr Mdl { get => ReadHere<IntPtr>(nameof(Mdl)); set => WriteHere(nameof(Mdl), value); }

        [Offset(48UL)]
        public IntPtr BaseAddress { get => ReadHere<IntPtr>(nameof(BaseAddress)); set => WriteHere(nameof(BaseAddress), value); }

        [Offset(56UL)]
        public ulong BaseLogicalAddress { get => ReadHere<ulong>(nameof(BaseLogicalAddress)); set => WriteHere(nameof(BaseLogicalAddress), value); }

        [Offset(64UL)]
        public IntPtr Entries { get => ReadHere<IntPtr>(nameof(Entries)); set => WriteHere(nameof(Entries), value); }

        [Offset(72UL)]
        public byte LogicalAddressMapped { get => ReadHere<byte>(nameof(LogicalAddressMapped)); set => WriteHere(nameof(LogicalAddressMapped), value); }

        public DmaCommonBufferVector(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DmaCommonBufferVector>();
        }
    }
}