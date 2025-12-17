using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_BOOT_OSL_RAMDISK_INFO")]
    public sealed class BootOslRamdiskInfo : DynamicStructure
    {
        [Offset(0UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(4UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(8UL)]
        [Length(1)]
        public DynamicArray Entries { get => ReadStructure<DynamicArray>(nameof(Entries)); set => WriteStructure(nameof(Entries), value); }

        public BootOslRamdiskInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<BootOslRamdiskInfo>();
        }
    }
}