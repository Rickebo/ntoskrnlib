#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _ARBITER_QUERY_CONFLICT_PARAMETERS
    {
        [FieldOffset(0)]
        public IntPtr PhysicalDeviceObject;
        [FieldOffset(8)]
        public IntPtr ConflictingResource;
        [FieldOffset(16)]
        public IntPtr ConflictCount;
        [FieldOffset(24)]
        public IntPtr Conflicts;
    }
}