using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_DRIVER_VA")]
    public sealed class MiDriverVa : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(8UL)]
        public IntPtr PointerPte { get => ReadHere<IntPtr>(nameof(PointerPte)); set => WriteHere(nameof(PointerPte), value); }

        [Offset(16UL)]
        public RtlBitmap BitMap { get => ReadStructure<RtlBitmap>(nameof(BitMap)); set => WriteStructure(nameof(BitMap), value); }

        [Offset(32UL)]
        public uint Hint { get => ReadHere<uint>(nameof(Hint)); set => WriteHere(nameof(Hint), value); }

        [Offset(36UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(40UL)]
        public RtlBitmap PageTableCommitmentBitMap { get => ReadStructure<RtlBitmap>(nameof(PageTableCommitmentBitMap)); set => WriteStructure(nameof(PageTableCommitmentBitMap), value); }

        public MiDriverVa(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiDriverVa>();
        }
    }
}