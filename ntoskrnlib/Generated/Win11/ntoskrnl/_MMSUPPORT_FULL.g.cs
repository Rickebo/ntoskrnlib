#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 320)]
    public partial struct _MMSUPPORT_FULL
    {
        [FieldOffset(0)]
        public _MMSUPPORT_INSTANCE Instance;
        [FieldOffset(192)]
        public _MMSUPPORT_SHARED Shared;
    }
}