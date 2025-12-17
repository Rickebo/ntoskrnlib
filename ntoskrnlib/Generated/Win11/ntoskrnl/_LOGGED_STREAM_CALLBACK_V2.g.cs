#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _LOGGED_STREAM_CALLBACK_V2
    {
        [FieldOffset(0)]
        public IntPtr LogHandleContext;
    }
}