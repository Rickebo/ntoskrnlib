using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOADER_PARAMETER_BLOCK")]
    public sealed class _LOADER_PARAMETER_BLOCK : DynamicStructure
    {
        public uint OsMajorVersion { get; }
        public uint OsMinorVersion { get; }
        public uint Size { get; }
        public uint OsLoaderSecurityVersion { get; }
        public _LIST_ENTRY LoadOrderListHead { get; }
        public _LIST_ENTRY MemoryDescriptorListHead { get; }
        public _LIST_ENTRY BootDriverListHead { get; }
        public _LIST_ENTRY EarlyLaunchListHead { get; }
        public _LIST_ENTRY CoreDriverListHead { get; }
        public _LIST_ENTRY CoreExtensionsDriverListHead { get; }
        public _LIST_ENTRY TpmCoreDriverListHead { get; }
        public ulong KernelStack { get; }
        public ulong Prcb { get; }
        public ulong Process { get; }
        public ulong Thread { get; }
        public uint KernelStackSize { get; }
        public uint RegistryLength { get; }
        public IntPtr RegistryBase { get; }
        public IntPtr ConfigurationRoot { get; }
        public IntPtr ArcBootDeviceName { get; }
        public IntPtr ArcHalDeviceName { get; }
        public IntPtr NtBootPathName { get; }
        public IntPtr NtHalPathName { get; }
        public IntPtr LoadOptions { get; }
        public IntPtr NlsData { get; }
        public IntPtr ArcDiskInformation { get; }
        public IntPtr Extension { get; }
        public _unnamed_tag_ u { get; }
        public _FIRMWARE_INFORMATION_LOADER_BLOCK FirmwareInformation { get; }
        public IntPtr OsBootstatPathName { get; }
        public IntPtr ArcOSDataDeviceName { get; }
        public IntPtr ArcWindowsSysPartName { get; }
        public _RTL_RB_TREE MemoryDescriptorTree { get; }

        public _LOADER_PARAMETER_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOADER_PARAMETER_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOADER_PARAMETER_BLOCK.OsMajorVersion),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.OsMinorVersion),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.Size),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.OsLoaderSecurityVersion),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.LoadOrderListHead),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.MemoryDescriptorListHead),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.BootDriverListHead),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.EarlyLaunchListHead),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.CoreDriverListHead),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.CoreExtensionsDriverListHead),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.TpmCoreDriverListHead),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.KernelStack),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.Prcb),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.Process),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.Thread),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.KernelStackSize),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.RegistryLength),
                    new ulong[]
                    {
                        164UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.RegistryBase),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.ConfigurationRoot),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.ArcBootDeviceName),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.ArcHalDeviceName),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.NtBootPathName),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.NtHalPathName),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.LoadOptions),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.NlsData),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.ArcDiskInformation),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.Extension),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.u),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.FirmwareInformation),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.OsBootstatPathName),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.ArcOSDataDeviceName),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.ArcWindowsSysPartName),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_BLOCK.MemoryDescriptorTree),
                    new ulong[]
                    {
                        352UL
                    }
                }
            };
            Register<_LOADER_PARAMETER_BLOCK>((mem, ptr) => new _LOADER_PARAMETER_BLOCK(mem, ptr), offsets);
        }
    }
}