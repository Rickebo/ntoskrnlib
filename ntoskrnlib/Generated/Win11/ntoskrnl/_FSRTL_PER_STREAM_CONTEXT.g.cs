#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _FSRTL_PER_STREAM_CONTEXT
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Links;
        [FieldOffset(16)]
        public IntPtr OwnerId;
        [FieldOffset(24)]
        public IntPtr InstanceId;
        [FieldOffset(32)]
        public IntPtr FreeCallback;
    }
}