#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _WHEA_ERROR_SOURCE_CONFIGURATION_DD
    {
        [FieldOffset(0)]
        public IntPtr Initialize;
        [FieldOffset(8)]
        public IntPtr Uninitialize;
        [FieldOffset(16)]
        public IntPtr Correct;
    }
}