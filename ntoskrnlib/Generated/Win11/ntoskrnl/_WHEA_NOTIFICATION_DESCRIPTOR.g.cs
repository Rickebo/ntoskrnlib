#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial struct _WHEA_NOTIFICATION_DESCRIPTOR
    {
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(1)]
        public byte Length;
        [FieldOffset(2)]
        public _WHEA_NOTIFICATION_FLAGS Flags;
        [FieldOffset(4)]
        public _unnamed_tag_ u;
    }
}