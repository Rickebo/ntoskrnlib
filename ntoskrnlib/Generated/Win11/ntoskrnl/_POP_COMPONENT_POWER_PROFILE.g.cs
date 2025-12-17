#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _POP_COMPONENT_POWER_PROFILE
    {
        [FieldOffset(0)]
        public _GUID ComponentGuid;
        [FieldOffset(16)]
        public IntPtr Device;
        [FieldOffset(24)]
        public ulong FxCount;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _PO_POWER_PLANE_PROFILE[] FxPower;
    }
}