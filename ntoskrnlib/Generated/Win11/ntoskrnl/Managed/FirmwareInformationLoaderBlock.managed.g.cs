using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FIRMWARE_INFORMATION_LOADER_BLOCK")]
    public sealed class FirmwareInformationLoaderBlock : DynamicStructure
    {
        [Offset(0UL)]
        public uint FirmwareTypeUefi { get => ReadHere<uint>(nameof(FirmwareTypeUefi)); set => WriteHere(nameof(FirmwareTypeUefi), value); }

        [Offset(0UL)]
        public uint EfiRuntimeUseIum { get => ReadHere<uint>(nameof(EfiRuntimeUseIum)); set => WriteHere(nameof(EfiRuntimeUseIum), value); }

        [Offset(0UL)]
        public uint EfiRuntimePageProtectionSupported { get => ReadHere<uint>(nameof(EfiRuntimePageProtectionSupported)); set => WriteHere(nameof(EfiRuntimePageProtectionSupported), value); }

        [Offset(0UL)]
        public uint Reserved1 { get => ReadHere<uint>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(0UL)]
        public uint SoftRebootMpwrResume { get => ReadHere<uint>(nameof(SoftRebootMpwrResume)); set => WriteHere(nameof(SoftRebootMpwrResume), value); }

        [Offset(0UL)]
        public uint Reserved2 { get => ReadHere<uint>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(8UL)]
        public UnnamedTag u { get => ReadStructure<UnnamedTag>(nameof(u)); set => WriteStructure(nameof(u), value); }

        public FirmwareInformationLoaderBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FirmwareInformationLoaderBlock>();
        }
    }
}