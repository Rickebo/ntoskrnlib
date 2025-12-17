using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_AUTHZBASEP_CLAIM_ATTRIBUTES_COLLECTION")]
    public sealed class _AUTHZBASEP_CLAIM_ATTRIBUTES_COLLECTION : DynamicStructure
    {
        public uint DeviceGroupsCount { get; }
        public IntPtr pDeviceGroups { get; }
        public uint RestrictedDeviceGroupsCount { get; }
        public IntPtr pRestrictedDeviceGroups { get; }
        public _SID_AND_ATTRIBUTES_HASH DeviceGroupsHash { get; }
        public _SID_AND_ATTRIBUTES_HASH RestrictedDeviceGroupsHash { get; }
        public IntPtr pUserSecurityAttributes { get; }
        public IntPtr pDeviceSecurityAttributes { get; }
        public IntPtr pRestrictedUserSecurityAttributes { get; }
        public IntPtr pRestrictedDeviceSecurityAttributes { get; }

        public _AUTHZBASEP_CLAIM_ATTRIBUTES_COLLECTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _AUTHZBASEP_CLAIM_ATTRIBUTES_COLLECTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_AUTHZBASEP_CLAIM_ATTRIBUTES_COLLECTION.DeviceGroupsCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AUTHZBASEP_CLAIM_ATTRIBUTES_COLLECTION.pDeviceGroups),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_AUTHZBASEP_CLAIM_ATTRIBUTES_COLLECTION.RestrictedDeviceGroupsCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_AUTHZBASEP_CLAIM_ATTRIBUTES_COLLECTION.pRestrictedDeviceGroups),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_AUTHZBASEP_CLAIM_ATTRIBUTES_COLLECTION.DeviceGroupsHash),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_AUTHZBASEP_CLAIM_ATTRIBUTES_COLLECTION.RestrictedDeviceGroupsHash),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_AUTHZBASEP_CLAIM_ATTRIBUTES_COLLECTION.pUserSecurityAttributes),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_AUTHZBASEP_CLAIM_ATTRIBUTES_COLLECTION.pDeviceSecurityAttributes),
                    new ulong[]
                    {
                        584UL
                    }
                },
                {
                    nameof(_AUTHZBASEP_CLAIM_ATTRIBUTES_COLLECTION.pRestrictedUserSecurityAttributes),
                    new ulong[]
                    {
                        592UL
                    }
                },
                {
                    nameof(_AUTHZBASEP_CLAIM_ATTRIBUTES_COLLECTION.pRestrictedDeviceSecurityAttributes),
                    new ulong[]
                    {
                        600UL
                    }
                }
            };
            Register<_AUTHZBASEP_CLAIM_ATTRIBUTES_COLLECTION>((mem, ptr) => new _AUTHZBASEP_CLAIM_ATTRIBUTES_COLLECTION(mem, ptr), offsets);
        }
    }
}