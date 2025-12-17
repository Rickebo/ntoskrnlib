using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_BUS_HANDLER")]
    public sealed class BusHandler : DynamicStructure
    {
        [Offset(0UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(4UL)]
        public uint InterfaceType { get => ReadHere<uint>(nameof(InterfaceType)); set => WriteHere(nameof(InterfaceType), value); }

        [Offset(8UL)]
        public uint ConfigurationType { get => ReadHere<uint>(nameof(ConfigurationType)); set => WriteHere(nameof(ConfigurationType), value); }

        [Offset(12UL)]
        public uint BusNumber { get => ReadHere<uint>(nameof(BusNumber)); set => WriteHere(nameof(BusNumber), value); }

        [Offset(16UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(24UL)]
        public IntPtr ParentHandler { get => ReadHere<IntPtr>(nameof(ParentHandler)); set => WriteHere(nameof(ParentHandler), value); }

        [Offset(32UL)]
        public IntPtr BusData { get => ReadHere<IntPtr>(nameof(BusData)); set => WriteHere(nameof(BusData), value); }

        [Offset(40UL)]
        public uint DeviceControlExtensionSize { get => ReadHere<uint>(nameof(DeviceControlExtensionSize)); set => WriteHere(nameof(DeviceControlExtensionSize), value); }

        [Offset(48UL)]
        public IntPtr BusAddresses { get => ReadHere<IntPtr>(nameof(BusAddresses)); set => WriteHere(nameof(BusAddresses), value); }

        [Offset(56UL)]
        [Length(4)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        [Offset(72UL)]
        public IntPtr GetBusData { get => ReadHere<IntPtr>(nameof(GetBusData)); set => WriteHere(nameof(GetBusData), value); }

        [Offset(80UL)]
        public IntPtr SetBusData { get => ReadHere<IntPtr>(nameof(SetBusData)); set => WriteHere(nameof(SetBusData), value); }

        [Offset(88UL)]
        public IntPtr AdjustResourceList { get => ReadHere<IntPtr>(nameof(AdjustResourceList)); set => WriteHere(nameof(AdjustResourceList), value); }

        [Offset(96UL)]
        public IntPtr AssignSlotResources { get => ReadHere<IntPtr>(nameof(AssignSlotResources)); set => WriteHere(nameof(AssignSlotResources), value); }

        [Offset(104UL)]
        public IntPtr TranslateBusAddress { get => ReadHere<IntPtr>(nameof(TranslateBusAddress)); set => WriteHere(nameof(TranslateBusAddress), value); }

        [Offset(112UL)]
        public IntPtr Spare1 { get => ReadHere<IntPtr>(nameof(Spare1)); set => WriteHere(nameof(Spare1), value); }

        [Offset(120UL)]
        public IntPtr Spare2 { get => ReadHere<IntPtr>(nameof(Spare2)); set => WriteHere(nameof(Spare2), value); }

        [Offset(128UL)]
        public IntPtr Spare3 { get => ReadHere<IntPtr>(nameof(Spare3)); set => WriteHere(nameof(Spare3), value); }

        [Offset(136UL)]
        public IntPtr Spare4 { get => ReadHere<IntPtr>(nameof(Spare4)); set => WriteHere(nameof(Spare4), value); }

        [Offset(144UL)]
        public IntPtr Spare5 { get => ReadHere<IntPtr>(nameof(Spare5)); set => WriteHere(nameof(Spare5), value); }

        [Offset(152UL)]
        public IntPtr Spare6 { get => ReadHere<IntPtr>(nameof(Spare6)); set => WriteHere(nameof(Spare6), value); }

        [Offset(160UL)]
        public IntPtr Spare7 { get => ReadHere<IntPtr>(nameof(Spare7)); set => WriteHere(nameof(Spare7), value); }

        [Offset(168UL)]
        public IntPtr Spare8 { get => ReadHere<IntPtr>(nameof(Spare8)); set => WriteHere(nameof(Spare8), value); }

        public BusHandler(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<BusHandler>();
        }
    }
}