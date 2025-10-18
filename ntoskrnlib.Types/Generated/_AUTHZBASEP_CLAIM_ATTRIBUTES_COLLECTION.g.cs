using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=608)]
public struct _AUTHZBASEP_CLAIM_ATTRIBUTES_COLLECTION
{
    [FieldOffset(0)]
    public uint DeviceGroupsCount;
    [FieldOffset(8)]
    public IntPtr pDeviceGroups;
    [FieldOffset(16)]
    public uint RestrictedDeviceGroupsCount;
    [FieldOffset(24)]
    public IntPtr pRestrictedDeviceGroups;
    [FieldOffset(32)]
    public _SID_AND_ATTRIBUTES_HASH DeviceGroupsHash;
    [FieldOffset(304)]
    public _SID_AND_ATTRIBUTES_HASH RestrictedDeviceGroupsHash;
    [FieldOffset(576)]
    public IntPtr pUserSecurityAttributes;
    [FieldOffset(584)]
    public IntPtr pDeviceSecurityAttributes;
    [FieldOffset(592)]
    public IntPtr pRestrictedUserSecurityAttributes;
    [FieldOffset(600)]
    public IntPtr pRestrictedDeviceSecurityAttributes;
}
