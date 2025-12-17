using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EFI_FIRMWARE_INFORMATION")]
    public sealed class EfiFirmwareInformation : DynamicStructure
    {
        [Offset(0UL)]
        public uint FirmwareVersion { get => ReadHere<uint>(nameof(FirmwareVersion)); set => WriteHere(nameof(FirmwareVersion), value); }

        [Offset(8UL)]
        public IntPtr VirtualEfiRuntimeServices { get => ReadHere<IntPtr>(nameof(VirtualEfiRuntimeServices)); set => WriteHere(nameof(VirtualEfiRuntimeServices), value); }

        [Offset(16UL)]
        public int SetVirtualAddressMapStatus { get => ReadHere<int>(nameof(SetVirtualAddressMapStatus)); set => WriteHere(nameof(SetVirtualAddressMapStatus), value); }

        [Offset(20UL)]
        public uint MissedMappingsCount { get => ReadHere<uint>(nameof(MissedMappingsCount)); set => WriteHere(nameof(MissedMappingsCount), value); }

        [Offset(24UL)]
        public ListEntry FirmwareResourceList { get => ReadStructure<ListEntry>(nameof(FirmwareResourceList)); set => WriteStructure(nameof(FirmwareResourceList), value); }

        [Offset(40UL)]
        public IntPtr EfiMemoryMap { get => ReadHere<IntPtr>(nameof(EfiMemoryMap)); set => WriteHere(nameof(EfiMemoryMap), value); }

        [Offset(48UL)]
        public uint EfiMemoryMapSize { get => ReadHere<uint>(nameof(EfiMemoryMapSize)); set => WriteHere(nameof(EfiMemoryMapSize), value); }

        [Offset(52UL)]
        public uint EfiMemoryMapDescriptorSize { get => ReadHere<uint>(nameof(EfiMemoryMapDescriptorSize)); set => WriteHere(nameof(EfiMemoryMapDescriptorSize), value); }

        public EfiFirmwareInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EfiFirmwareInformation>();
        }
    }
}