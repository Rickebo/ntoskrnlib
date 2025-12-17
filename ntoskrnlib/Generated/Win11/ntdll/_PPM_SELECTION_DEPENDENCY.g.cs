#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _PPM_SELECTION_DEPENDENCY
    {
        [FieldOffset(0)]
        public uint Processor;
        [FieldOffset(8)]
        public _PPM_SELECTION_MENU Menu;
    }
}