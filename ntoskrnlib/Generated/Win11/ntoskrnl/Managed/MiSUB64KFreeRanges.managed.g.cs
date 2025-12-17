using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SUB64K_FREE_RANGES")]
    public sealed class MiSUB64KFreeRanges : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBitmapEx BitMap { get => ReadStructure<RtlBitmapEx>(nameof(BitMap)); set => WriteStructure(nameof(BitMap), value); }

        [Offset(16UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(32UL)]
        public IntPtr Vad { get => ReadHere<IntPtr>(nameof(Vad)); set => WriteHere(nameof(Vad), value); }

        [Offset(40UL)]
        public uint SetBits { get => ReadHere<uint>(nameof(SetBits)); set => WriteHere(nameof(SetBits), value); }

        [Offset(44UL)]
        public uint FullSetBits { get => ReadHere<uint>(nameof(FullSetBits)); set => WriteHere(nameof(FullSetBits), value); }

        [Offset(48UL)]
        public uint SubListIndex { get => ReadHere<uint>(nameof(SubListIndex)); set => WriteHere(nameof(SubListIndex), value); }

        [Offset(48UL)]
        public uint Hint { get => ReadHere<uint>(nameof(Hint)); set => WriteHere(nameof(Hint), value); }

        public MiSUB64KFreeRanges(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSUB64KFreeRanges>();
        }
    }
}