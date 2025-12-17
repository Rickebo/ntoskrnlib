#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial struct _CVDD
    {
        [FieldOffset(0)]
        public uint Signature;
        [FieldOffset(0)]
        public _NB10 NB10;
        [FieldOffset(0)]
        public _RSDS RsDs;
    }
}