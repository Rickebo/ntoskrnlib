#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 736)]
    public partial struct _OBP_SILODRIVERSTATE
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
}