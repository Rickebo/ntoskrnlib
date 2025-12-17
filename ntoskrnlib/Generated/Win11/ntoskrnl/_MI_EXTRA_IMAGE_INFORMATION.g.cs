#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _MI_EXTRA_IMAGE_INFORMATION
    {
        [FieldOffset(0)]
        public uint SizeOfHeaders;
        [FieldOffset(4)]
        public uint SizeOfImage;
        [FieldOffset(8)]
        public uint TimeDateStamp;
        [FieldOffset(12)]
        public uint ImageCetShadowStacksReady;
        [FieldOffset(12)]
        public uint ImageCetShadowStacksStrictMode;
        [FieldOffset(12)]
        public uint ImageCetSetContextIpValidationRelaxedMode;
        [FieldOffset(12)]
        public uint ImageCetDynamicApisAllowInProc;
        [FieldOffset(12)]
        public uint ImageCetDowngradeReserved1;
        [FieldOffset(12)]
        public uint ImageCetDowngradeReserved2;
        [FieldOffset(12)]
        public uint ImageExpansionCompatible;
        [FieldOffset(12)]
        public uint Spare;
    }
}