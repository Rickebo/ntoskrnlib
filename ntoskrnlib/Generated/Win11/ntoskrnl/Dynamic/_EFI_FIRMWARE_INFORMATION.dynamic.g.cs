using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EFI_FIRMWARE_INFORMATION")]
    public sealed class _EFI_FIRMWARE_INFORMATION : DynamicStructure
    {
        public uint FirmwareVersion { get; }
        public IntPtr VirtualEfiRuntimeServices { get; }
        public int SetVirtualAddressMapStatus { get; }
        public uint MissedMappingsCount { get; }
        public _LIST_ENTRY FirmwareResourceList { get; }
        public IntPtr EfiMemoryMap { get; }
        public uint EfiMemoryMapSize { get; }
        public uint EfiMemoryMapDescriptorSize { get; }

        public _EFI_FIRMWARE_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EFI_FIRMWARE_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EFI_FIRMWARE_INFORMATION.FirmwareVersion),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EFI_FIRMWARE_INFORMATION.VirtualEfiRuntimeServices),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EFI_FIRMWARE_INFORMATION.SetVirtualAddressMapStatus),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_EFI_FIRMWARE_INFORMATION.MissedMappingsCount),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_EFI_FIRMWARE_INFORMATION.FirmwareResourceList),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_EFI_FIRMWARE_INFORMATION.EfiMemoryMap),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_EFI_FIRMWARE_INFORMATION.EfiMemoryMapSize),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_EFI_FIRMWARE_INFORMATION.EfiMemoryMapDescriptorSize),
                    new ulong[]
                    {
                        52UL
                    }
                }
            };
            Register<_EFI_FIRMWARE_INFORMATION>((mem, ptr) => new _EFI_FIRMWARE_INFORMATION(mem, ptr), offsets);
        }
    }
}