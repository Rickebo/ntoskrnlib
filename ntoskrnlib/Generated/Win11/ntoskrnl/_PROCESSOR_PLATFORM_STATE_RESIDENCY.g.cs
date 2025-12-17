#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PROCESSOR_PLATFORM_STATE_RESIDENCY
    {
        [FieldOffset(0)]
        public ulong Residency;
        [FieldOffset(8)]
        public ulong TransitionCount;
    }
}