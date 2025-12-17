using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_BOOT_OSL_RAMDISK_ENTRY")]
    public sealed class _BOOT_OSL_RAMDISK_ENTRY : DynamicStructure
    {
        public uint BlockSize { get; }
        public ulong BaseAddress { get; }
        public ulong Size { get; }

        public _BOOT_OSL_RAMDISK_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _BOOT_OSL_RAMDISK_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_BOOT_OSL_RAMDISK_ENTRY.BlockSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_BOOT_OSL_RAMDISK_ENTRY.BaseAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_BOOT_OSL_RAMDISK_ENTRY.Size),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_BOOT_OSL_RAMDISK_ENTRY>((mem, ptr) => new _BOOT_OSL_RAMDISK_ENTRY(mem, ptr), offsets);
        }
    }
}