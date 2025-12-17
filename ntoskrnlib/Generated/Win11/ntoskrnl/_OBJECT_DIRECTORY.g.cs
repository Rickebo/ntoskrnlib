#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 344)]
    public partial struct _OBJECT_DIRECTORY
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 37)]
        public IntPtr[] HashBuckets;
        [FieldOffset(296)]
        public _EX_PUSH_LOCK Lock;
        [FieldOffset(304)]
        public IntPtr DeviceMap;
        [FieldOffset(312)]
        public IntPtr ShadowDirectory;
        [FieldOffset(320)]
        public IntPtr NamespaceEntry;
        [FieldOffset(328)]
        public IntPtr SessionObject;
        [FieldOffset(336)]
        public uint Flags;
        [FieldOffset(340)]
        public uint SessionId;
    }
}