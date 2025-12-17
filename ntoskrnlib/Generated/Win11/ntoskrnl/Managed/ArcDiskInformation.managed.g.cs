using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ARC_DISK_INFORMATION")]
    public sealed class ArcDiskInformation : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry DiskSignatures { get => ReadStructure<ListEntry>(nameof(DiskSignatures)); set => WriteStructure(nameof(DiskSignatures), value); }

        public ArcDiskInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ArcDiskInformation>();
        }
    }
}