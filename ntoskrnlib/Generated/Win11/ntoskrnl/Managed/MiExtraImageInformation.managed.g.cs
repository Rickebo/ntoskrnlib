using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_EXTRA_IMAGE_INFORMATION")]
    public sealed class MiExtraImageInformation : DynamicStructure
    {
        [Offset(0UL)]
        public uint SizeOfHeaders { get => ReadHere<uint>(nameof(SizeOfHeaders)); set => WriteHere(nameof(SizeOfHeaders), value); }

        [Offset(4UL)]
        public uint SizeOfImage { get => ReadHere<uint>(nameof(SizeOfImage)); set => WriteHere(nameof(SizeOfImage), value); }

        [Offset(8UL)]
        public uint TimeDateStamp { get => ReadHere<uint>(nameof(TimeDateStamp)); set => WriteHere(nameof(TimeDateStamp), value); }

        [Offset(12UL)]
        public uint ImageCetShadowStacksReady { get => ReadHere<uint>(nameof(ImageCetShadowStacksReady)); set => WriteHere(nameof(ImageCetShadowStacksReady), value); }

        [Offset(12UL)]
        public uint ImageCetShadowStacksStrictMode { get => ReadHere<uint>(nameof(ImageCetShadowStacksStrictMode)); set => WriteHere(nameof(ImageCetShadowStacksStrictMode), value); }

        [Offset(12UL)]
        public uint ImageCetSetContextIpValidationRelaxedMode { get => ReadHere<uint>(nameof(ImageCetSetContextIpValidationRelaxedMode)); set => WriteHere(nameof(ImageCetSetContextIpValidationRelaxedMode), value); }

        [Offset(12UL)]
        public uint ImageCetDynamicApisAllowInProc { get => ReadHere<uint>(nameof(ImageCetDynamicApisAllowInProc)); set => WriteHere(nameof(ImageCetDynamicApisAllowInProc), value); }

        [Offset(12UL)]
        public uint ImageCetDowngradeReserved1 { get => ReadHere<uint>(nameof(ImageCetDowngradeReserved1)); set => WriteHere(nameof(ImageCetDowngradeReserved1), value); }

        [Offset(12UL)]
        public uint ImageCetDowngradeReserved2 { get => ReadHere<uint>(nameof(ImageCetDowngradeReserved2)); set => WriteHere(nameof(ImageCetDowngradeReserved2), value); }

        [Offset(12UL)]
        public uint ImageExpansionCompatible { get => ReadHere<uint>(nameof(ImageExpansionCompatible)); set => WriteHere(nameof(ImageExpansionCompatible), value); }

        [Offset(12UL)]
        public uint Spare { get => ReadHere<uint>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        public MiExtraImageInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiExtraImageInformation>();
        }
    }
}