using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMVAD_FLAGS2")]
    public sealed class MmvadFLAGS2 : DynamicStructure
    {
        [Offset(0UL)]
        public uint Large { get => ReadHere<uint>(nameof(Large)); set => WriteHere(nameof(Large), value); }

        [Offset(0UL)]
        public uint TrimBehind { get => ReadHere<uint>(nameof(TrimBehind)); set => WriteHere(nameof(TrimBehind), value); }

        [Offset(0UL)]
        public uint Inherit { get => ReadHere<uint>(nameof(Inherit)); set => WriteHere(nameof(Inherit), value); }

        [Offset(0UL)]
        public uint NoValidationNeeded { get => ReadHere<uint>(nameof(NoValidationNeeded)); set => WriteHere(nameof(NoValidationNeeded), value); }

        [Offset(0UL)]
        public uint PrivateDemandZero { get => ReadHere<uint>(nameof(PrivateDemandZero)); set => WriteHere(nameof(PrivateDemandZero), value); }

        [Offset(0UL)]
        public uint ImageMappingExtended { get => ReadHere<uint>(nameof(ImageMappingExtended)); set => WriteHere(nameof(ImageMappingExtended), value); }

        [Offset(0UL)]
        public uint Spare { get => ReadHere<uint>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(0UL)]
        public uint LongFlags { get => ReadHere<uint>(nameof(LongFlags)); set => WriteHere(nameof(LongFlags), value); }

        public MmvadFLAGS2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmvadFLAGS2>();
        }
    }
}