#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PPM_SELECTION_MENU
    {
        [FieldOffset(0)]
        public uint Count;
        [FieldOffset(8)]
        public IntPtr Entries;
    }
}