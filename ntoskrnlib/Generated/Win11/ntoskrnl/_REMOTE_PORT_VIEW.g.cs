#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _REMOTE_PORT_VIEW
    {
        [FieldOffset(0)]
        public uint Length;
        [FieldOffset(8)]
        public ulong ViewSize;
        [FieldOffset(16)]
        public IntPtr ViewBase;
    }
}