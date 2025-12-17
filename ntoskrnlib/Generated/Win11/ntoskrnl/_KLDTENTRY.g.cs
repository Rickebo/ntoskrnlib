#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _KLDTENTRY
    {
        [FieldOffset(0)]
        public ushort LimitLow;
        [FieldOffset(2)]
        public ushort BaseLow;
        [FieldOffset(4)]
        public _unnamed_tag_ HighWord;
    }
}