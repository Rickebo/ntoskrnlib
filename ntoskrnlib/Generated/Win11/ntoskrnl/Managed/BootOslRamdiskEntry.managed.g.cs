using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_BOOT_OSL_RAMDISK_ENTRY")]
    public sealed class BootOslRamdiskEntry : DynamicStructure
    {
        [Offset(0UL)]
        public uint BlockSize { get => ReadHere<uint>(nameof(BlockSize)); set => WriteHere(nameof(BlockSize), value); }

        [Offset(8UL)]
        public ulong BaseAddress { get => ReadHere<ulong>(nameof(BaseAddress)); set => WriteHere(nameof(BaseAddress), value); }

        [Offset(16UL)]
        public ulong Size { get => ReadHere<ulong>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        public BootOslRamdiskEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<BootOslRamdiskEntry>();
        }
    }
}