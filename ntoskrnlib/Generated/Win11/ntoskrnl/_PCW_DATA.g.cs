#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PCW_DATA
    {
        [FieldOffset(0)]
        public IntPtr Data;
        [FieldOffset(8)]
        public uint Size;
    }
}