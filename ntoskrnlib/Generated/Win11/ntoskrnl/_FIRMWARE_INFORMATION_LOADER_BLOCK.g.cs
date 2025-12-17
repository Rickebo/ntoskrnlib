#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _FIRMWARE_INFORMATION_LOADER_BLOCK
    {
        [FieldOffset(0)]
        public uint FirmwareTypeUefi;
        [FieldOffset(0)]
        public uint EfiRuntimeUseIum;
        [FieldOffset(0)]
        public uint EfiRuntimePageProtectionSupported;
        [FieldOffset(0)]
        public uint Reserved1;
        [FieldOffset(0)]
        public uint SoftRebootMpwrResume;
        [FieldOffset(0)]
        public uint Reserved2;
        [FieldOffset(8)]
        public _unnamed_tag_ u;
    }
}