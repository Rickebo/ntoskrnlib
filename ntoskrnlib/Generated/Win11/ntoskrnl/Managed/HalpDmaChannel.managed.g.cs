using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HALP_DMA_CHANNEL")]
    public sealed class HalpDmaChannel : DynamicStructure
    {
        [Offset(0UL)]
        public uint ChannelNumber { get => ReadHere<uint>(nameof(ChannelNumber)); set => WriteHere(nameof(ChannelNumber), value); }

        [Offset(4UL)]
        public byte Initialized { get => ReadHere<byte>(nameof(Initialized)); set => WriteHere(nameof(Initialized), value); }

        [Offset(5UL)]
        public byte Busy { get => ReadHere<byte>(nameof(Busy)); set => WriteHere(nameof(Busy), value); }

        [Offset(6UL)]
        public byte Complete { get => ReadHere<byte>(nameof(Complete)); set => WriteHere(nameof(Complete), value); }

        [Offset(8UL)]
        public IntPtr CurrentCompletionRoutine { get => ReadHere<IntPtr>(nameof(CurrentCompletionRoutine)); set => WriteHere(nameof(CurrentCompletionRoutine), value); }

        [Offset(16UL)]
        public IntPtr CurrentCompletionContext { get => ReadHere<IntPtr>(nameof(CurrentCompletionContext)); set => WriteHere(nameof(CurrentCompletionContext), value); }

        [Offset(24UL)]
        public IntPtr CurrentChildAdapter { get => ReadHere<IntPtr>(nameof(CurrentChildAdapter)); set => WriteHere(nameof(CurrentChildAdapter), value); }

        [Offset(32UL)]
        public uint CurrentInterruptType { get => ReadHere<uint>(nameof(CurrentInterruptType)); set => WriteHere(nameof(CurrentInterruptType), value); }

        [Offset(40UL)]
        public Kdpc Dpc { get => ReadStructure<Kdpc>(nameof(Dpc)); set => WriteStructure(nameof(Dpc), value); }

        [Offset(104UL)]
        public byte GeneratesInterrupt { get => ReadHere<byte>(nameof(GeneratesInterrupt)); set => WriteHere(nameof(GeneratesInterrupt), value); }

        [Offset(108UL)]
        public int Gsi { get => ReadHere<int>(nameof(Gsi)); set => WriteHere(nameof(Gsi), value); }

        [Offset(112UL)]
        public uint InterruptPolarity { get => ReadHere<uint>(nameof(InterruptPolarity)); set => WriteHere(nameof(InterruptPolarity), value); }

        [Offset(116UL)]
        public uint InterruptMode { get => ReadHere<uint>(nameof(InterruptMode)); set => WriteHere(nameof(InterruptMode), value); }

        [Offset(120UL)]
        public uint CommonBufferLength { get => ReadHere<uint>(nameof(CommonBufferLength)); set => WriteHere(nameof(CommonBufferLength), value); }

        [Offset(128UL)]
        public IntPtr CommonBufferVirtualAddress { get => ReadHere<IntPtr>(nameof(CommonBufferVirtualAddress)); set => WriteHere(nameof(CommonBufferVirtualAddress), value); }

        [Offset(136UL)]
        public LargeInteger CommonBufferLogicalAddress { get => ReadStructure<LargeInteger>(nameof(CommonBufferLogicalAddress)); set => WriteStructure(nameof(CommonBufferLogicalAddress), value); }

        [Offset(144UL)]
        public ListEntry AdapterQueue { get => ReadStructure<ListEntry>(nameof(AdapterQueue)); set => WriteStructure(nameof(AdapterQueue), value); }

        public HalpDmaChannel(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalpDmaChannel>();
        }
    }
}