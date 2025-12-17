using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SEGMENT_SIGNATURE_FLAGS")]
    public sealed class MiSegmentSignatureFlags : DynamicStructure
    {
        [Offset(0UL)]
        public byte ImageSigningLevel { get => ReadHere<byte>(nameof(ImageSigningLevel)); set => WriteHere(nameof(ImageSigningLevel), value); }

        [Offset(0UL)]
        public byte ImageSigningType { get => ReadHere<byte>(nameof(ImageSigningType)); set => WriteHere(nameof(ImageSigningType), value); }

        [Offset(0UL)]
        public byte Spare { get => ReadHere<byte>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(0UL)]
        public byte EntireField { get => ReadHere<byte>(nameof(EntireField)); set => WriteHere(nameof(EntireField), value); }

        public MiSegmentSignatureFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSegmentSignatureFlags>();
        }
    }
}