using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WNF_STATE_DATA")]
    public sealed class WnfStateData : DynamicStructure
    {
        [Offset(0UL)]
        public WnfNodeHeader Header { get => ReadStructure<WnfNodeHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(4UL)]
        public uint AllocatedSize { get => ReadHere<uint>(nameof(AllocatedSize)); set => WriteHere(nameof(AllocatedSize), value); }

        [Offset(8UL)]
        public uint DataSize { get => ReadHere<uint>(nameof(DataSize)); set => WriteHere(nameof(DataSize), value); }

        [Offset(12UL)]
        public uint ChangeStamp { get => ReadHere<uint>(nameof(ChangeStamp)); set => WriteHere(nameof(ChangeStamp), value); }

        public WnfStateData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WnfStateData>();
        }
    }
}