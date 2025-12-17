using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HALP_DMA_CONTROLLER")]
    public sealed class HalpDmaController : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Controllers { get => ReadStructure<ListEntry>(nameof(Controllers)); set => WriteStructure(nameof(Controllers), value); }

        [Offset(16UL)]
        public ListEntry AdapterList { get => ReadStructure<ListEntry>(nameof(AdapterList)); set => WriteStructure(nameof(AdapterList), value); }

        [Offset(32UL)]
        public uint ControllerId { get => ReadHere<uint>(nameof(ControllerId)); set => WriteHere(nameof(ControllerId), value); }

        [Offset(36UL)]
        public uint MinimumRequestLine { get => ReadHere<uint>(nameof(MinimumRequestLine)); set => WriteHere(nameof(MinimumRequestLine), value); }

        [Offset(40UL)]
        public uint MaximumRequestLine { get => ReadHere<uint>(nameof(MaximumRequestLine)); set => WriteHere(nameof(MaximumRequestLine), value); }

        [Offset(44UL)]
        public uint ChannelCount { get => ReadHere<uint>(nameof(ChannelCount)); set => WriteHere(nameof(ChannelCount), value); }

        [Offset(48UL)]
        public uint ScatterGatherLimit { get => ReadHere<uint>(nameof(ScatterGatherLimit)); set => WriteHere(nameof(ScatterGatherLimit), value); }

        [Offset(56UL)]
        public IntPtr Channels { get => ReadHere<IntPtr>(nameof(Channels)); set => WriteHere(nameof(Channels), value); }

        [Offset(64UL)]
        public IntPtr ExtensionData { get => ReadHere<IntPtr>(nameof(ExtensionData)); set => WriteHere(nameof(ExtensionData), value); }

        [Offset(72UL)]
        public byte CacheCoherent { get => ReadHere<byte>(nameof(CacheCoherent)); set => WriteHere(nameof(CacheCoherent), value); }

        [Offset(76UL)]
        public uint DmaAddressWidth { get => ReadHere<uint>(nameof(DmaAddressWidth)); set => WriteHere(nameof(DmaAddressWidth), value); }

        [Offset(80UL)]
        public DmaFunctionTable Operations { get => ReadStructure<DmaFunctionTable>(nameof(Operations)); set => WriteStructure(nameof(Operations), value); }

        [Offset(160UL)]
        public uint SupportedPortWidths { get => ReadHere<uint>(nameof(SupportedPortWidths)); set => WriteHere(nameof(SupportedPortWidths), value); }

        [Offset(164UL)]
        public uint MinimumTransferUnit { get => ReadHere<uint>(nameof(MinimumTransferUnit)); set => WriteHere(nameof(MinimumTransferUnit), value); }

        [Offset(168UL)]
        public ulong Lock { get => ReadHere<ulong>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(176UL)]
        public byte Irql { get => ReadHere<byte>(nameof(Irql)); set => WriteHere(nameof(Irql), value); }

        [Offset(177UL)]
        public byte GeneratesInterrupt { get => ReadHere<byte>(nameof(GeneratesInterrupt)); set => WriteHere(nameof(GeneratesInterrupt), value); }

        [Offset(180UL)]
        public int Gsi { get => ReadHere<int>(nameof(Gsi)); set => WriteHere(nameof(Gsi), value); }

        [Offset(184UL)]
        public uint InterruptPolarity { get => ReadHere<uint>(nameof(InterruptPolarity)); set => WriteHere(nameof(InterruptPolarity), value); }

        [Offset(188UL)]
        public uint InterruptMode { get => ReadHere<uint>(nameof(InterruptMode)); set => WriteHere(nameof(InterruptMode), value); }

        [Offset(192UL)]
        public UnicodeString ResourceId { get => ReadStructure<UnicodeString>(nameof(ResourceId)); set => WriteStructure(nameof(ResourceId), value); }

        [Offset(208UL)]
        public IntPtr PowerHandle { get => ReadHere<IntPtr>(nameof(PowerHandle)); set => WriteHere(nameof(PowerHandle), value); }

        [Offset(216UL)]
        public byte PowerActive { get => ReadHere<byte>(nameof(PowerActive)); set => WriteHere(nameof(PowerActive), value); }

        public HalpDmaController(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalpDmaController>();
        }
    }
}