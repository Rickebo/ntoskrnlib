using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MIPFNBLINK")]
    public sealed class Mipfnblink : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Blink { get => ReadHere<ulong>(nameof(Blink)); set => WriteHere(nameof(Blink), value); }

        [Offset(0UL)]
        public ulong NodeBlinkLow { get => ReadHere<ulong>(nameof(NodeBlinkLow)); set => WriteHere(nameof(NodeBlinkLow), value); }

        [Offset(0UL)]
        public ulong TbFlushStamp { get => ReadHere<ulong>(nameof(TbFlushStamp)); set => WriteHere(nameof(TbFlushStamp), value); }

        [Offset(0UL)]
        public ulong PageBlinkDeleteBit { get => ReadHere<ulong>(nameof(PageBlinkDeleteBit)); set => WriteHere(nameof(PageBlinkDeleteBit), value); }

        [Offset(0UL)]
        public ulong PageBlinkLockBit { get => ReadHere<ulong>(nameof(PageBlinkLockBit)); set => WriteHere(nameof(PageBlinkLockBit), value); }

        [Offset(0UL)]
        public ulong ShareCount { get => ReadHere<ulong>(nameof(ShareCount)); set => WriteHere(nameof(ShareCount), value); }

        [Offset(0UL)]
        public ulong PageShareCountDeleteBit { get => ReadHere<ulong>(nameof(PageShareCountDeleteBit)); set => WriteHere(nameof(PageShareCountDeleteBit), value); }

        [Offset(0UL)]
        public ulong PageShareCountLockBit { get => ReadHere<ulong>(nameof(PageShareCountLockBit)); set => WriteHere(nameof(PageShareCountLockBit), value); }

        [Offset(0UL)]
        public long EntireField { get => ReadHere<long>(nameof(EntireField)); set => WriteHere(nameof(EntireField), value); }

        [Offset(0UL)]
        public ulong LockNotUsed { get => ReadHere<ulong>(nameof(LockNotUsed)); set => WriteHere(nameof(LockNotUsed), value); }

        [Offset(0UL)]
        public ulong DeleteBit { get => ReadHere<ulong>(nameof(DeleteBit)); set => WriteHere(nameof(DeleteBit), value); }

        [Offset(0UL)]
        public ulong LockBit { get => ReadHere<ulong>(nameof(LockBit)); set => WriteHere(nameof(LockBit), value); }

        public Mipfnblink(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Mipfnblink>();
        }
    }
}