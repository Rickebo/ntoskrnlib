using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DMA_TRANSFER_CONTEXT_V1")]
    public sealed class DmaTransferContextV1 : DynamicStructure
    {
        [Offset(0UL)]
        public int DmaState { get => ReadHere<int>(nameof(DmaState)); set => WriteHere(nameof(DmaState), value); }

        [Offset(4UL)]
        public uint TransferState { get => ReadHere<uint>(nameof(TransferState)); set => WriteHere(nameof(TransferState), value); }

        [Offset(8UL)]
        public WaitContextBlock Wcb { get => ReadStructure<WaitContextBlock>(nameof(Wcb)); set => WriteStructure(nameof(Wcb), value); }

        [Offset(80UL)]
        public IntPtr HalWcb { get => ReadHere<IntPtr>(nameof(HalWcb)); set => WriteHere(nameof(HalWcb), value); }

        public DmaTransferContextV1(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DmaTransferContextV1>();
        }
    }
}