#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _COMPOSITEFS_LAYER_INFORMATION
    {
        [FieldOffset(0)]
        public uint DeviceType;
        [FieldOffset(8)]
        public _unnamed_tag_ u;
    }
}