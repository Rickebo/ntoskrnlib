#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _MI_CONTROL_AREA_WAIT_BLOCK
    {
        [FieldOffset(0)]
        public IntPtr Next;
        [FieldOffset(8)]
        public uint WaitReason;
        [FieldOffset(12)]
        public uint WaitResponse;
        [FieldOffset(16)]
        public _KGATE Gate;
    }
}