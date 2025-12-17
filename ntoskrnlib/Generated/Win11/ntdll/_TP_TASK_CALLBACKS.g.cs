#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _TP_TASK_CALLBACKS
    {
        [FieldOffset(0)]
        public IntPtr ExecuteCallback;
        [FieldOffset(8)]
        public IntPtr Unposted;
    }
}