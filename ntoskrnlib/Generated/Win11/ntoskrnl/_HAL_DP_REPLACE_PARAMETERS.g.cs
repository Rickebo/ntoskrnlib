#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _HAL_DP_REPLACE_PARAMETERS
    {
        [FieldOffset(0)]
        public uint Flags;
        [FieldOffset(8)]
        public IntPtr TargetProcessors;
        [FieldOffset(16)]
        public IntPtr SpareProcessors;
    }
}