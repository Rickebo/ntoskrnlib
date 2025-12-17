using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PCAT_FIRMWARE_INFORMATION")]
    public sealed class PcatFirmwareInformation : DynamicStructure
    {
        [Offset(0UL)]
        public uint PlaceHolder { get => ReadHere<uint>(nameof(PlaceHolder)); set => WriteHere(nameof(PlaceHolder), value); }

        public PcatFirmwareInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PcatFirmwareInformation>();
        }
    }
}