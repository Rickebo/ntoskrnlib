using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOADER_PARAMETER_HYPERVISOR_EXTENSION")]
    public sealed class _LOADER_PARAMETER_HYPERVISOR_EXTENSION : DynamicStructure
    {
        public uint InitialHypervisorCrashdumpAreaPageCount { get; }
        public uint HypervisorCrashdumpAreaPageCount { get; }
        public ulong InitialHypervisorCrashdumpAreaSpa { get; }
        public ulong HypervisorCrashdumpAreaSpa { get; }
        public ulong HypervisorLaunchStatus { get; }
        public ulong HypervisorLaunchStatusArg1 { get; }
        public ulong HypervisorLaunchStatusArg2 { get; }
        public ulong HypervisorLaunchStatusArg3 { get; }
        public ulong HypervisorLaunchStatusArg4 { get; }
        public IntPtr RangeArray { get; }
        public uint RangeCount { get; }

        public _LOADER_PARAMETER_HYPERVISOR_EXTENSION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOADER_PARAMETER_HYPERVISOR_EXTENSION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOADER_PARAMETER_HYPERVISOR_EXTENSION.InitialHypervisorCrashdumpAreaPageCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_HYPERVISOR_EXTENSION.HypervisorCrashdumpAreaPageCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_HYPERVISOR_EXTENSION.InitialHypervisorCrashdumpAreaSpa),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_HYPERVISOR_EXTENSION.HypervisorCrashdumpAreaSpa),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_HYPERVISOR_EXTENSION.HypervisorLaunchStatus),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_HYPERVISOR_EXTENSION.HypervisorLaunchStatusArg1),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_HYPERVISOR_EXTENSION.HypervisorLaunchStatusArg2),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_HYPERVISOR_EXTENSION.HypervisorLaunchStatusArg3),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_HYPERVISOR_EXTENSION.HypervisorLaunchStatusArg4),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_HYPERVISOR_EXTENSION.RangeArray),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_HYPERVISOR_EXTENSION.RangeCount),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_LOADER_PARAMETER_HYPERVISOR_EXTENSION>((mem, ptr) => new _LOADER_PARAMETER_HYPERVISOR_EXTENSION(mem, ptr), offsets);
        }
    }
}