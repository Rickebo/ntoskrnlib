using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DMA_OPERATIONS")]
    public sealed class DmaOperations : DynamicStructure
    {
        [Offset(0UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public IntPtr PutDmaAdapter { get => ReadHere<IntPtr>(nameof(PutDmaAdapter)); set => WriteHere(nameof(PutDmaAdapter), value); }

        [Offset(16UL)]
        public IntPtr AllocateCommonBuffer { get => ReadHere<IntPtr>(nameof(AllocateCommonBuffer)); set => WriteHere(nameof(AllocateCommonBuffer), value); }

        [Offset(24UL)]
        public IntPtr FreeCommonBuffer { get => ReadHere<IntPtr>(nameof(FreeCommonBuffer)); set => WriteHere(nameof(FreeCommonBuffer), value); }

        [Offset(32UL)]
        public IntPtr AllocateAdapterChannel { get => ReadHere<IntPtr>(nameof(AllocateAdapterChannel)); set => WriteHere(nameof(AllocateAdapterChannel), value); }

        [Offset(40UL)]
        public IntPtr FlushAdapterBuffers { get => ReadHere<IntPtr>(nameof(FlushAdapterBuffers)); set => WriteHere(nameof(FlushAdapterBuffers), value); }

        [Offset(48UL)]
        public IntPtr FreeAdapterChannel { get => ReadHere<IntPtr>(nameof(FreeAdapterChannel)); set => WriteHere(nameof(FreeAdapterChannel), value); }

        [Offset(56UL)]
        public IntPtr FreeMapRegisters { get => ReadHere<IntPtr>(nameof(FreeMapRegisters)); set => WriteHere(nameof(FreeMapRegisters), value); }

        [Offset(64UL)]
        public IntPtr MapTransfer { get => ReadHere<IntPtr>(nameof(MapTransfer)); set => WriteHere(nameof(MapTransfer), value); }

        [Offset(72UL)]
        public IntPtr GetDmaAlignment { get => ReadHere<IntPtr>(nameof(GetDmaAlignment)); set => WriteHere(nameof(GetDmaAlignment), value); }

        [Offset(80UL)]
        public IntPtr ReadDmaCounter { get => ReadHere<IntPtr>(nameof(ReadDmaCounter)); set => WriteHere(nameof(ReadDmaCounter), value); }

        [Offset(88UL)]
        public IntPtr GetScatterGatherList { get => ReadHere<IntPtr>(nameof(GetScatterGatherList)); set => WriteHere(nameof(GetScatterGatherList), value); }

        [Offset(96UL)]
        public IntPtr PutScatterGatherList { get => ReadHere<IntPtr>(nameof(PutScatterGatherList)); set => WriteHere(nameof(PutScatterGatherList), value); }

        [Offset(104UL)]
        public IntPtr CalculateScatterGatherList { get => ReadHere<IntPtr>(nameof(CalculateScatterGatherList)); set => WriteHere(nameof(CalculateScatterGatherList), value); }

        [Offset(112UL)]
        public IntPtr BuildScatterGatherList { get => ReadHere<IntPtr>(nameof(BuildScatterGatherList)); set => WriteHere(nameof(BuildScatterGatherList), value); }

        [Offset(120UL)]
        public IntPtr BuildMdlFromScatterGatherList { get => ReadHere<IntPtr>(nameof(BuildMdlFromScatterGatherList)); set => WriteHere(nameof(BuildMdlFromScatterGatherList), value); }

        [Offset(128UL)]
        public IntPtr GetDmaAdapterInfo { get => ReadHere<IntPtr>(nameof(GetDmaAdapterInfo)); set => WriteHere(nameof(GetDmaAdapterInfo), value); }

        [Offset(136UL)]
        public IntPtr GetDmaTransferInfo { get => ReadHere<IntPtr>(nameof(GetDmaTransferInfo)); set => WriteHere(nameof(GetDmaTransferInfo), value); }

        [Offset(144UL)]
        public IntPtr InitializeDmaTransferContext { get => ReadHere<IntPtr>(nameof(InitializeDmaTransferContext)); set => WriteHere(nameof(InitializeDmaTransferContext), value); }

        [Offset(152UL)]
        public IntPtr AllocateCommonBufferEx { get => ReadHere<IntPtr>(nameof(AllocateCommonBufferEx)); set => WriteHere(nameof(AllocateCommonBufferEx), value); }

        [Offset(160UL)]
        public IntPtr AllocateAdapterChannelEx { get => ReadHere<IntPtr>(nameof(AllocateAdapterChannelEx)); set => WriteHere(nameof(AllocateAdapterChannelEx), value); }

        [Offset(168UL)]
        public IntPtr ConfigureAdapterChannel { get => ReadHere<IntPtr>(nameof(ConfigureAdapterChannel)); set => WriteHere(nameof(ConfigureAdapterChannel), value); }

        [Offset(176UL)]
        public IntPtr CancelAdapterChannel { get => ReadHere<IntPtr>(nameof(CancelAdapterChannel)); set => WriteHere(nameof(CancelAdapterChannel), value); }

        [Offset(184UL)]
        public IntPtr MapTransferEx { get => ReadHere<IntPtr>(nameof(MapTransferEx)); set => WriteHere(nameof(MapTransferEx), value); }

        [Offset(192UL)]
        public IntPtr GetScatterGatherListEx { get => ReadHere<IntPtr>(nameof(GetScatterGatherListEx)); set => WriteHere(nameof(GetScatterGatherListEx), value); }

        [Offset(200UL)]
        public IntPtr BuildScatterGatherListEx { get => ReadHere<IntPtr>(nameof(BuildScatterGatherListEx)); set => WriteHere(nameof(BuildScatterGatherListEx), value); }

        [Offset(208UL)]
        public IntPtr FlushAdapterBuffersEx { get => ReadHere<IntPtr>(nameof(FlushAdapterBuffersEx)); set => WriteHere(nameof(FlushAdapterBuffersEx), value); }

        [Offset(216UL)]
        public IntPtr FreeAdapterObject { get => ReadHere<IntPtr>(nameof(FreeAdapterObject)); set => WriteHere(nameof(FreeAdapterObject), value); }

        [Offset(224UL)]
        public IntPtr CancelMappedTransfer { get => ReadHere<IntPtr>(nameof(CancelMappedTransfer)); set => WriteHere(nameof(CancelMappedTransfer), value); }

        [Offset(232UL)]
        public IntPtr AllocateDomainCommonBuffer { get => ReadHere<IntPtr>(nameof(AllocateDomainCommonBuffer)); set => WriteHere(nameof(AllocateDomainCommonBuffer), value); }

        [Offset(240UL)]
        public IntPtr FlushDmaBuffer { get => ReadHere<IntPtr>(nameof(FlushDmaBuffer)); set => WriteHere(nameof(FlushDmaBuffer), value); }

        [Offset(248UL)]
        public IntPtr JoinDmaDomain { get => ReadHere<IntPtr>(nameof(JoinDmaDomain)); set => WriteHere(nameof(JoinDmaDomain), value); }

        [Offset(256UL)]
        public IntPtr LeaveDmaDomain { get => ReadHere<IntPtr>(nameof(LeaveDmaDomain)); set => WriteHere(nameof(LeaveDmaDomain), value); }

        [Offset(264UL)]
        public IntPtr GetDmaDomain { get => ReadHere<IntPtr>(nameof(GetDmaDomain)); set => WriteHere(nameof(GetDmaDomain), value); }

        [Offset(272UL)]
        public IntPtr AllocateCommonBufferWithBounds { get => ReadHere<IntPtr>(nameof(AllocateCommonBufferWithBounds)); set => WriteHere(nameof(AllocateCommonBufferWithBounds), value); }

        [Offset(280UL)]
        public IntPtr AllocateCommonBufferVector { get => ReadHere<IntPtr>(nameof(AllocateCommonBufferVector)); set => WriteHere(nameof(AllocateCommonBufferVector), value); }

        [Offset(288UL)]
        public IntPtr GetCommonBufferFromVectorByIndex { get => ReadHere<IntPtr>(nameof(GetCommonBufferFromVectorByIndex)); set => WriteHere(nameof(GetCommonBufferFromVectorByIndex), value); }

        [Offset(296UL)]
        public IntPtr FreeCommonBufferFromVector { get => ReadHere<IntPtr>(nameof(FreeCommonBufferFromVector)); set => WriteHere(nameof(FreeCommonBufferFromVector), value); }

        [Offset(304UL)]
        public IntPtr FreeCommonBufferVector { get => ReadHere<IntPtr>(nameof(FreeCommonBufferVector)); set => WriteHere(nameof(FreeCommonBufferVector), value); }

        [Offset(312UL)]
        public IntPtr CreateCommonBufferFromMdl { get => ReadHere<IntPtr>(nameof(CreateCommonBufferFromMdl)); set => WriteHere(nameof(CreateCommonBufferFromMdl), value); }

        public DmaOperations(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DmaOperations>();
        }
    }
}