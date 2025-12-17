using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PI_BUS_EXTENSION")]
    public sealed class PiBusExtension : DynamicStructure
    {
        [Offset(0UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(4UL)]
        public byte NumberCSNs { get => ReadHere<byte>(nameof(NumberCSNs)); set => WriteHere(nameof(NumberCSNs), value); }

        [Offset(8UL)]
        public IntPtr ReadDataPort { get => ReadHere<IntPtr>(nameof(ReadDataPort)); set => WriteHere(nameof(ReadDataPort), value); }

        [Offset(16UL)]
        public byte DataPortMapped { get => ReadHere<byte>(nameof(DataPortMapped)); set => WriteHere(nameof(DataPortMapped), value); }

        [Offset(24UL)]
        public IntPtr AddressPort { get => ReadHere<IntPtr>(nameof(AddressPort)); set => WriteHere(nameof(AddressPort), value); }

        [Offset(32UL)]
        public byte AddrPortMapped { get => ReadHere<byte>(nameof(AddrPortMapped)); set => WriteHere(nameof(AddrPortMapped), value); }

        [Offset(40UL)]
        public IntPtr CommandPort { get => ReadHere<IntPtr>(nameof(CommandPort)); set => WriteHere(nameof(CommandPort), value); }

        [Offset(48UL)]
        public byte CmdPortMapped { get => ReadHere<byte>(nameof(CmdPortMapped)); set => WriteHere(nameof(CmdPortMapped), value); }

        [Offset(52UL)]
        public uint NextSlotNumber { get => ReadHere<uint>(nameof(NextSlotNumber)); set => WriteHere(nameof(NextSlotNumber), value); }

        [Offset(56UL)]
        public SingleListEntry DeviceList { get => ReadStructure<SingleListEntry>(nameof(DeviceList)); set => WriteStructure(nameof(DeviceList), value); }

        [Offset(64UL)]
        public SingleListEntry CardList { get => ReadStructure<SingleListEntry>(nameof(CardList)); set => WriteStructure(nameof(CardList), value); }

        [Offset(72UL)]
        public IntPtr PhysicalBusDevice { get => ReadHere<IntPtr>(nameof(PhysicalBusDevice)); set => WriteHere(nameof(PhysicalBusDevice), value); }

        [Offset(80UL)]
        public IntPtr FunctionalBusDevice { get => ReadHere<IntPtr>(nameof(FunctionalBusDevice)); set => WriteHere(nameof(FunctionalBusDevice), value); }

        [Offset(88UL)]
        public IntPtr AttachedDevice { get => ReadHere<IntPtr>(nameof(AttachedDevice)); set => WriteHere(nameof(AttachedDevice), value); }

        [Offset(96UL)]
        public uint BusNumber { get => ReadHere<uint>(nameof(BusNumber)); set => WriteHere(nameof(BusNumber), value); }

        [Offset(100UL)]
        public uint SystemPowerState { get => ReadHere<uint>(nameof(SystemPowerState)); set => WriteHere(nameof(SystemPowerState), value); }

        [Offset(104UL)]
        public uint DevicePowerState { get => ReadHere<uint>(nameof(DevicePowerState)); set => WriteHere(nameof(DevicePowerState), value); }

        public PiBusExtension(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PiBusExtension>();
        }
    }
}