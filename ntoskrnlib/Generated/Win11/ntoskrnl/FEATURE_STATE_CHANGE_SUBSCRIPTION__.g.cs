#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct FEATURE_STATE_CHANGE_SUBSCRIPTION__
    {
        [FieldOffset(0)]
        public int unused;
    }
}