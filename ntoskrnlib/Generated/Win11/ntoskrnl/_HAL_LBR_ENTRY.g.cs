#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _HAL_LBR_ENTRY
    {
        [FieldOffset(0)]
        public IntPtr FromAddress;
        [FieldOffset(8)]
        public IntPtr ToAddress;
        [FieldOffset(16)]
        public IntPtr Information;
    }
}