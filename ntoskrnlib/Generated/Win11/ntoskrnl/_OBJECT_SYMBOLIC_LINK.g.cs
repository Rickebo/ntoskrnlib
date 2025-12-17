#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _OBJECT_SYMBOLIC_LINK
    {
        [FieldOffset(0)]
        public _LARGE_INTEGER CreationTime;
        [FieldOffset(8)]
        public _UNICODE_STRING LinkTarget;
        [FieldOffset(8)]
        public IntPtr Callback;
        [FieldOffset(16)]
        public IntPtr CallbackContext;
        [FieldOffset(24)]
        public uint DosDeviceDriveIndex;
        [FieldOffset(28)]
        public uint Flags;
        [FieldOffset(32)]
        public uint AccessMask;
        [FieldOffset(36)]
        public uint IntegrityLevel;
    }
}