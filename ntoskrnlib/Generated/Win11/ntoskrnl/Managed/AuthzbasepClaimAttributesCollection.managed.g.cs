using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_AUTHZBASEP_CLAIM_ATTRIBUTES_COLLECTION")]
    public sealed class AuthzbasepClaimAttributesCollection : DynamicStructure
    {
        [Offset(0UL)]
        public uint DeviceGroupsCount { get => ReadHere<uint>(nameof(DeviceGroupsCount)); set => WriteHere(nameof(DeviceGroupsCount), value); }

        [Offset(8UL)]
        public IntPtr pDeviceGroups { get => ReadHere<IntPtr>(nameof(pDeviceGroups)); set => WriteHere(nameof(pDeviceGroups), value); }

        [Offset(16UL)]
        public uint RestrictedDeviceGroupsCount { get => ReadHere<uint>(nameof(RestrictedDeviceGroupsCount)); set => WriteHere(nameof(RestrictedDeviceGroupsCount), value); }

        [Offset(24UL)]
        public IntPtr pRestrictedDeviceGroups { get => ReadHere<IntPtr>(nameof(pRestrictedDeviceGroups)); set => WriteHere(nameof(pRestrictedDeviceGroups), value); }

        [Offset(32UL)]
        public SidAndAttributesHash DeviceGroupsHash { get => ReadStructure<SidAndAttributesHash>(nameof(DeviceGroupsHash)); set => WriteStructure(nameof(DeviceGroupsHash), value); }

        [Offset(304UL)]
        public SidAndAttributesHash RestrictedDeviceGroupsHash { get => ReadStructure<SidAndAttributesHash>(nameof(RestrictedDeviceGroupsHash)); set => WriteStructure(nameof(RestrictedDeviceGroupsHash), value); }

        [Offset(576UL)]
        public IntPtr pUserSecurityAttributes { get => ReadHere<IntPtr>(nameof(pUserSecurityAttributes)); set => WriteHere(nameof(pUserSecurityAttributes), value); }

        [Offset(584UL)]
        public IntPtr pDeviceSecurityAttributes { get => ReadHere<IntPtr>(nameof(pDeviceSecurityAttributes)); set => WriteHere(nameof(pDeviceSecurityAttributes), value); }

        [Offset(592UL)]
        public IntPtr pRestrictedUserSecurityAttributes { get => ReadHere<IntPtr>(nameof(pRestrictedUserSecurityAttributes)); set => WriteHere(nameof(pRestrictedUserSecurityAttributes), value); }

        [Offset(600UL)]
        public IntPtr pRestrictedDeviceSecurityAttributes { get => ReadHere<IntPtr>(nameof(pRestrictedDeviceSecurityAttributes)); set => WriteHere(nameof(pRestrictedDeviceSecurityAttributes), value); }

        public AuthzbasepClaimAttributesCollection(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AuthzbasepClaimAttributesCollection>();
        }
    }
}