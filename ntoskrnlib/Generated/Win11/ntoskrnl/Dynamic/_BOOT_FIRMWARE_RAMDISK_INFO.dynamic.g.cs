using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_BOOT_FIRMWARE_RAMDISK_INFO")]
    public sealed class _BOOT_FIRMWARE_RAMDISK_INFO : DynamicStructure
    {
        public uint Version { get; }
        public uint BlockSize { get; }
        public ulong BaseAddress { get; }
        public ulong Size { get; }

        public _BOOT_FIRMWARE_RAMDISK_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _BOOT_FIRMWARE_RAMDISK_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_BOOT_FIRMWARE_RAMDISK_INFO.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_BOOT_FIRMWARE_RAMDISK_INFO.BlockSize),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_BOOT_FIRMWARE_RAMDISK_INFO.BaseAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_BOOT_FIRMWARE_RAMDISK_INFO.Size),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_BOOT_FIRMWARE_RAMDISK_INFO>((mem, ptr) => new _BOOT_FIRMWARE_RAMDISK_INFO(mem, ptr), offsets);
        }
    }
}