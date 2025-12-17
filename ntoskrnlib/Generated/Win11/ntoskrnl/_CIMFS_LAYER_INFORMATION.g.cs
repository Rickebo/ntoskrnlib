#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _CIMFS_LAYER_INFORMATION
    {
        [FieldOffset(0)]
        public _GUID TargetVolume;
        [FieldOffset(16)]
        public IntPtr CimFiles;
        [FieldOffset(24)]
        public uint CimFilesCount;
        [FieldOffset(28)]
        public uint MountFlags;
        [FieldOffset(32)]
        public byte ParentIsVsmb;
        [FieldOffset(40)]
        public IntPtr ParentDeviceArcName;
    }
}