using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_BOOT_OSL_RAMDISK_INFO")]
    public sealed class _BOOT_OSL_RAMDISK_INFO : DynamicStructure
    {
        public uint Version { get; }
        public uint Count { get; }
        public byte[] Entries { get; }

        public _BOOT_OSL_RAMDISK_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _BOOT_OSL_RAMDISK_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_BOOT_OSL_RAMDISK_INFO.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_BOOT_OSL_RAMDISK_INFO.Count),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_BOOT_OSL_RAMDISK_INFO.Entries),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_BOOT_OSL_RAMDISK_INFO>((mem, ptr) => new _BOOT_OSL_RAMDISK_INFO(mem, ptr), offsets);
        }
    }
}