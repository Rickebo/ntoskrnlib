using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=736)]
public struct _OBP_SILODRIVERSTATE
{
    [FieldOffset(0)]
    public _EX_FAST_REF SystemDeviceMap;
    [FieldOffset(8)]
    public _OBP_SYSTEM_DOS_DEVICE_STATE SystemDosDeviceState;
    [FieldOffset(120)]
    public _EX_PUSH_LOCK DeviceMapLock;
    [FieldOffset(128)]
    public _OBJECT_NAMESPACE_LOOKUPTABLE PrivateNamespaceLookupTable;
}
