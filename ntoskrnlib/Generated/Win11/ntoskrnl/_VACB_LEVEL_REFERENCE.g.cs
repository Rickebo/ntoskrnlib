#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _VACB_LEVEL_REFERENCE
    {
        [FieldOffset(0)]
        public int Reference;
        [FieldOffset(4)]
        public int SpecialReference;
    }
}