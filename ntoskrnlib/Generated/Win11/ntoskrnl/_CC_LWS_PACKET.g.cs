#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _CC_LWS_PACKET
    {
        [FieldOffset(0)]
        public uint Type;
        [FieldOffset(4)]
        public byte Active;
        [FieldOffset(8)]
        public _unnamed_tag_ Overlay;
    }
}