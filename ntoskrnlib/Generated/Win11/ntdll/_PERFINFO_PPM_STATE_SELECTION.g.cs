#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _PERFINFO_PPM_STATE_SELECTION
    {
        [FieldOffset(0)]
        public uint SelectedState;
        [FieldOffset(4)]
        public uint VetoedStates;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public uint[] VetoReason;
    }
}