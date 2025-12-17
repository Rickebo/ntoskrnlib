using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KSR_FIRMWARE_INFORMATION")]
    public sealed class _KSR_FIRMWARE_INFORMATION : DynamicStructure
    {
        public uint Version { get; }
        public _KSR_CAPABILITIES DownlevelCapabilities { get; }
        public _UNICODE_STRING EfiVersionString { get; }
        public _VIRTUAL_EFI_RUNTIME_SERVICES EfiRuntimeServices { get; }
        public IntPtr EfiMemoryMap { get; }
        public uint EfiMemoryMapSize { get; }
        public uint EfiMemoryMapDescriptorSize { get; }
        public IntPtr CachingRequirements { get; }
        public uint CachingRequirementsCount { get; }
        public IntPtr Smbios { get; }
        public IntPtr DisplayContext { get; }
        public IntPtr SecureBootPolicy { get; }
        public uint SecureBootPolicySize { get; }
        public DEBUG_MEMORY_REQUIREMENTS DebugDeviceMemory { get; }
        public uint SoftRestartCount { get; }
        public IntPtr CodeIntegrityPolicy { get; }
        public uint CodeIntegrityPolicySize { get; }
        public IntPtr EfiMemoryAttributes { get; }
        public IntPtr Esrt { get; }
        public uint EsrtSize { get; }
        public IntPtr CodeIntegrityPolicyHash { get; }
        public uint CodeIntegrityPolicyHashSize { get; }
        public IntPtr CodeIntegrityPolicyOriginalHash { get; }
        public uint CodeIntegrityPolicyOriginalHashSize { get; }
        public IntPtr BadPageRanges { get; }
        public uint BadPageRangeCount { get; }
        public _KSR_CAPABILITIES Capabilities { get; }
        public _KSR_FLAGS Flags { get; }

        public _KSR_FIRMWARE_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSR_FIRMWARE_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.DownlevelCapabilities),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.EfiVersionString),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.EfiRuntimeServices),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.EfiMemoryMap),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.EfiMemoryMapSize),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.EfiMemoryMapDescriptorSize),
                    new ulong[]
                    {
                        148UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.CachingRequirements),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.CachingRequirementsCount),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.Smbios),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.DisplayContext),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.SecureBootPolicy),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.SecureBootPolicySize),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.DebugDeviceMemory),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.SoftRestartCount),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.CodeIntegrityPolicy),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.CodeIntegrityPolicySize),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.EfiMemoryAttributes),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.Esrt),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.EsrtSize),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.CodeIntegrityPolicyHash),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.CodeIntegrityPolicyHashSize),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.CodeIntegrityPolicyOriginalHash),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.CodeIntegrityPolicyOriginalHashSize),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.BadPageRanges),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.BadPageRangeCount),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.Capabilities),
                    new ulong[]
                    {
                        324UL
                    }
                },
                {
                    nameof(_KSR_FIRMWARE_INFORMATION.Flags),
                    new ulong[]
                    {
                        328UL
                    }
                }
            };
            Register<_KSR_FIRMWARE_INFORMATION>((mem, ptr) => new _KSR_FIRMWARE_INFORMATION(mem, ptr), offsets);
        }
    }
}