#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _TEB_ACTIVE_FRAME_CONTEXT
    {
        [FieldOffset(0)]
        public uint Flags;
        [FieldOffset(8)]
        public IntPtr FrameName;
    }
}