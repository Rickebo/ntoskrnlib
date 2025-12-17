using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ETW_GUID_ENTRY")]
    public sealed class _ETW_GUID_ENTRY : DynamicStructure
    {
        public _LIST_ENTRY GuidList { get; }
        public _LIST_ENTRY SiloGuidList { get; }
        public long RefCount { get; }
        public _GUID Guid { get; }
        public _LIST_ENTRY RegListHead { get; }
        public IntPtr SecurityDescriptor { get; }
        public _ETW_LAST_ENABLE_INFO LastEnable { get; }
        public ulong MatchId { get; }
        public _TRACE_ENABLE_INFO ProviderEnableInfo { get; }
        public byte[] EnableInfo { get; }
        public IntPtr FilterData { get; }
        public IntPtr SiloState { get; }
        public IntPtr HostEntry { get; }
        public _EX_PUSH_LOCK Lock { get; }
        public IntPtr LockOwner { get; }

        public _ETW_GUID_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ETW_GUID_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ETW_GUID_ENTRY.GuidList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ETW_GUID_ENTRY.SiloGuidList),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_ETW_GUID_ENTRY.RefCount),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_ETW_GUID_ENTRY.Guid),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_ETW_GUID_ENTRY.RegListHead),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_ETW_GUID_ENTRY.SecurityDescriptor),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_ETW_GUID_ENTRY.LastEnable),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_ETW_GUID_ENTRY.MatchId),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_ETW_GUID_ENTRY.ProviderEnableInfo),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_ETW_GUID_ENTRY.EnableInfo),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_ETW_GUID_ENTRY.FilterData),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_ETW_GUID_ENTRY.SiloState),
                    new ulong[]
                    {
                        392UL
                    }
                },
                {
                    nameof(_ETW_GUID_ENTRY.HostEntry),
                    new ulong[]
                    {
                        400UL
                    }
                },
                {
                    nameof(_ETW_GUID_ENTRY.Lock),
                    new ulong[]
                    {
                        408UL
                    }
                },
                {
                    nameof(_ETW_GUID_ENTRY.LockOwner),
                    new ulong[]
                    {
                        416UL
                    }
                }
            };
            Register<_ETW_GUID_ENTRY>((mem, ptr) => new _ETW_GUID_ENTRY(mem, ptr), offsets);
        }
    }
}