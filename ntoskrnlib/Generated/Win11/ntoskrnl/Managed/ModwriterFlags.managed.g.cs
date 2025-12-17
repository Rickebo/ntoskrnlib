using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MODWRITER_FLAGS")]
    public sealed class ModwriterFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint KeepForever { get => ReadHere<uint>(nameof(KeepForever)); set => WriteHere(nameof(KeepForever), value); }

        [Offset(0UL)]
        public uint Networked { get => ReadHere<uint>(nameof(Networked)); set => WriteHere(nameof(Networked), value); }

        [Offset(0UL)]
        public uint IoPriority { get => ReadHere<uint>(nameof(IoPriority)); set => WriteHere(nameof(IoPriority), value); }

        [Offset(0UL)]
        public uint PfBacked { get => ReadHere<uint>(nameof(PfBacked)); set => WriteHere(nameof(PfBacked), value); }

        [Offset(0UL)]
        public uint ModifiedStoreWrite { get => ReadHere<uint>(nameof(ModifiedStoreWrite)); set => WriteHere(nameof(ModifiedStoreWrite), value); }

        public ModwriterFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ModwriterFlags>();
        }
    }
}