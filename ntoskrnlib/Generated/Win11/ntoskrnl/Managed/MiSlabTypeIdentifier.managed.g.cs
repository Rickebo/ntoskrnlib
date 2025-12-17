using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SLAB_TYPE_IDENTIFIER")]
    public sealed class MiSlabTypeIdentifier : DynamicStructure
    {
        [Offset(0UL)]
        public byte SlabType { get => ReadHere<byte>(nameof(SlabType)); set => WriteHere(nameof(SlabType), value); }

        [Offset(1UL)]
        public byte SlabIdentity { get => ReadHere<byte>(nameof(SlabIdentity)); set => WriteHere(nameof(SlabIdentity), value); }

        [Offset(1UL)]
        public byte ChargesAcquired { get => ReadHere<byte>(nameof(ChargesAcquired)); set => WriteHere(nameof(ChargesAcquired), value); }

        public MiSlabTypeIdentifier(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSlabTypeIdentifier>();
        }
    }
}