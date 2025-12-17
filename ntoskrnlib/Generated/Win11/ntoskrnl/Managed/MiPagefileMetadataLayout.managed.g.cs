using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_PAGEFILE_METADATA_LAYOUT")]
    public sealed class MiPagefileMetadataLayout : DynamicStructure
    {
        [Offset(0UL)]
        public uint EntryInBytes { get => ReadHere<uint>(nameof(EntryInBytes)); set => WriteHere(nameof(EntryInBytes), value); }

        [Offset(4UL)]
        public uint OwningPteOffset { get => ReadHere<uint>(nameof(OwningPteOffset)); set => WriteHere(nameof(OwningPteOffset), value); }

        public MiPagefileMetadataLayout(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiPagefileMetadataLayout>();
        }
    }
}