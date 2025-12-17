#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _ARBITER_PARAMETERS
    {
        [FieldOffset(0)]
        public _unnamed_tag_ Parameters;
    }
}