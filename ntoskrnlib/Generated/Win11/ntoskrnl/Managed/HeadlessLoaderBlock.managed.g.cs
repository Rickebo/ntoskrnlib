using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEADLESS_LOADER_BLOCK")]
    public sealed class HeadlessLoaderBlock : DynamicStructure
    {
        [Offset(0UL)]
        public byte UsedBiosSettings { get => ReadHere<byte>(nameof(UsedBiosSettings)); set => WriteHere(nameof(UsedBiosSettings), value); }

        [Offset(1UL)]
        public byte DataBits { get => ReadHere<byte>(nameof(DataBits)); set => WriteHere(nameof(DataBits), value); }

        [Offset(2UL)]
        public byte StopBits { get => ReadHere<byte>(nameof(StopBits)); set => WriteHere(nameof(StopBits), value); }

        [Offset(3UL)]
        public byte Parity { get => ReadHere<byte>(nameof(Parity)); set => WriteHere(nameof(Parity), value); }

        [Offset(4UL)]
        public uint BaudRate { get => ReadHere<uint>(nameof(BaudRate)); set => WriteHere(nameof(BaudRate), value); }

        [Offset(8UL)]
        public uint PortNumber { get => ReadHere<uint>(nameof(PortNumber)); set => WriteHere(nameof(PortNumber), value); }

        [Offset(16UL)]
        public IntPtr PortAddress { get => ReadHere<IntPtr>(nameof(PortAddress)); set => WriteHere(nameof(PortAddress), value); }

        [Offset(24UL)]
        public ushort PciDeviceId { get => ReadHere<ushort>(nameof(PciDeviceId)); set => WriteHere(nameof(PciDeviceId), value); }

        [Offset(26UL)]
        public ushort PciVendorId { get => ReadHere<ushort>(nameof(PciVendorId)); set => WriteHere(nameof(PciVendorId), value); }

        [Offset(28UL)]
        public byte PciBusNumber { get => ReadHere<byte>(nameof(PciBusNumber)); set => WriteHere(nameof(PciBusNumber), value); }

        [Offset(30UL)]
        public ushort PciBusSegment { get => ReadHere<ushort>(nameof(PciBusSegment)); set => WriteHere(nameof(PciBusSegment), value); }

        [Offset(32UL)]
        public byte PciSlotNumber { get => ReadHere<byte>(nameof(PciSlotNumber)); set => WriteHere(nameof(PciSlotNumber), value); }

        [Offset(33UL)]
        public byte PciFunctionNumber { get => ReadHere<byte>(nameof(PciFunctionNumber)); set => WriteHere(nameof(PciFunctionNumber), value); }

        [Offset(36UL)]
        public uint PciFlags { get => ReadHere<uint>(nameof(PciFlags)); set => WriteHere(nameof(PciFlags), value); }

        [Offset(40UL)]
        public Guid SystemGUID { get => ReadStructure<Guid>(nameof(SystemGUID)); set => WriteStructure(nameof(SystemGUID), value); }

        [Offset(56UL)]
        public byte IsMMIODevice { get => ReadHere<byte>(nameof(IsMMIODevice)); set => WriteHere(nameof(IsMMIODevice), value); }

        [Offset(57UL)]
        public byte TerminalType { get => ReadHere<byte>(nameof(TerminalType)); set => WriteHere(nameof(TerminalType), value); }

        [Offset(58UL)]
        public byte InterfaceType { get => ReadHere<byte>(nameof(InterfaceType)); set => WriteHere(nameof(InterfaceType), value); }

        [Offset(59UL)]
        public byte RegisterBitWidth { get => ReadHere<byte>(nameof(RegisterBitWidth)); set => WriteHere(nameof(RegisterBitWidth), value); }

        [Offset(60UL)]
        public byte RegisterAccessSize { get => ReadHere<byte>(nameof(RegisterAccessSize)); set => WriteHere(nameof(RegisterAccessSize), value); }

        public HeadlessLoaderBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeadlessLoaderBlock>();
        }
    }
}