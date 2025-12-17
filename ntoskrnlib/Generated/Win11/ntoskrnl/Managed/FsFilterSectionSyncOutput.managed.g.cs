using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FS_FILTER_SECTION_SYNC_OUTPUT")]
    public sealed class FsFilterSectionSyncOutput : DynamicStructure
    {
        [Offset(0UL)]
        public uint StructureSize { get => ReadHere<uint>(nameof(StructureSize)); set => WriteHere(nameof(StructureSize), value); }

        [Offset(4UL)]
        public uint SizeReturned { get => ReadHere<uint>(nameof(SizeReturned)); set => WriteHere(nameof(SizeReturned), value); }

        [Offset(8UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(12UL)]
        public uint DesiredReadAlignment { get => ReadHere<uint>(nameof(DesiredReadAlignment)); set => WriteHere(nameof(DesiredReadAlignment), value); }

        public FsFilterSectionSyncOutput(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FsFilterSectionSyncOutput>();
        }
    }
}