#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _INTERRUPT_REMAPPING_INFO
    {
        [FieldOffset(0)]
        public uint IrtIndex;
        [FieldOffset(0)]
        public uint FlagHalInternal;
        [FieldOffset(0)]
        public uint FlagTranslated;
        [FieldOffset(4)]
        public _unnamed_tag_ u;
    }
}