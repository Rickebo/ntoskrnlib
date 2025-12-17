using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SLAB_IDENTITY_REFERENCE")]
    public sealed class MiSlabIdentityReference : DynamicStructure
    {
        [Offset(0UL)]
        public long ReferenceCount { get => ReadHere<long>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        public MiSlabIdentityReference(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSlabIdentityReference>();
        }
    }
}