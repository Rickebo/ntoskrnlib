#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _WHEAP_ERROR_RECORD_WRAPPER_FLAGS
    {
        [FieldOffset(0)]
        public uint Preallocated;
        [FieldOffset(0)]
        public uint FromPersistentStore;
        [FieldOffset(0)]
        public uint PlatformPfaControl;
        [FieldOffset(0)]
        public uint PlatformDirectedOffline;
        [FieldOffset(0)]
        public uint Reserved;
        [FieldOffset(0)]
        public uint AsULONG;
    }
}