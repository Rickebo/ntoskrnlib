#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HAL_LOG_REGISTER_CONTEXT
    {
        [FieldOffset(0)]
        public IntPtr LogRoutine;
        [FieldOffset(8)]
        public uint Flag;
    }
}