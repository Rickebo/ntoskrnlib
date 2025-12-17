#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _MI_PHYSICAL_VIEW
    {
        [FieldOffset(0)]
        public _RTL_BALANCED_NODE PhysicalNode;
        [FieldOffset(24)]
        public IntPtr Vad;
        [FieldOffset(32)]
        public IntPtr AweInfo;
        [FieldOffset(40)]
        public _unnamed_tag_ u1;
        [FieldOffset(48)]
        public _RTL_BITMAP_EX BitMap;
        [FieldOffset(64)]
        public byte AgeStamp;
    }
}