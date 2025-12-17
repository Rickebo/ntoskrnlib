#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _LOGGED_STREAM_CALLBACK_V1
    {
        [FieldOffset(0)]
        public IntPtr LogHandle;
        [FieldOffset(8)]
        public IntPtr FlushToLsnRoutine;
    }
}