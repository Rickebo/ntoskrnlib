#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _PROCESSOR_PLATFORM_STATE_RESIDENCIES
    {
        [FieldOffset(0)]
        public uint Count;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _PROCESSOR_PLATFORM_STATE_RESIDENCY[] States;
    }
}