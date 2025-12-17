#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _ARBITER_BOOT_ALLOCATION_PARAMETERS
    {
        [FieldOffset(0)]
        public IntPtr ArbitrationList;
    }
}