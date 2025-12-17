using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VIRTUAL_EFI_RUNTIME_SERVICES")]
    public sealed class _VIRTUAL_EFI_RUNTIME_SERVICES : DynamicStructure
    {
        public ulong GetTime { get; }
        public ulong SetTime { get; }
        public ulong GetWakeupTime { get; }
        public ulong SetWakeupTime { get; }
        public ulong SetVirtualAddressMap { get; }
        public ulong ConvertPointer { get; }
        public ulong GetVariable { get; }
        public ulong GetNextVariableName { get; }
        public ulong SetVariable { get; }
        public ulong GetNextHighMonotonicCount { get; }
        public ulong ResetSystem { get; }
        public ulong UpdateCapsule { get; }
        public ulong QueryCapsuleCapabilities { get; }
        public ulong QueryVariableInfo { get; }

        public _VIRTUAL_EFI_RUNTIME_SERVICES(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VIRTUAL_EFI_RUNTIME_SERVICES()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VIRTUAL_EFI_RUNTIME_SERVICES.GetTime),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VIRTUAL_EFI_RUNTIME_SERVICES.SetTime),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VIRTUAL_EFI_RUNTIME_SERVICES.GetWakeupTime),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_VIRTUAL_EFI_RUNTIME_SERVICES.SetWakeupTime),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_VIRTUAL_EFI_RUNTIME_SERVICES.SetVirtualAddressMap),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_VIRTUAL_EFI_RUNTIME_SERVICES.ConvertPointer),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_VIRTUAL_EFI_RUNTIME_SERVICES.GetVariable),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_VIRTUAL_EFI_RUNTIME_SERVICES.GetNextVariableName),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_VIRTUAL_EFI_RUNTIME_SERVICES.SetVariable),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_VIRTUAL_EFI_RUNTIME_SERVICES.GetNextHighMonotonicCount),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_VIRTUAL_EFI_RUNTIME_SERVICES.ResetSystem),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_VIRTUAL_EFI_RUNTIME_SERVICES.UpdateCapsule),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_VIRTUAL_EFI_RUNTIME_SERVICES.QueryCapsuleCapabilities),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_VIRTUAL_EFI_RUNTIME_SERVICES.QueryVariableInfo),
                    new ulong[]
                    {
                        104UL
                    }
                }
            };
            Register<_VIRTUAL_EFI_RUNTIME_SERVICES>((mem, ptr) => new _VIRTUAL_EFI_RUNTIME_SERVICES(mem, ptr), offsets);
        }
    }
}