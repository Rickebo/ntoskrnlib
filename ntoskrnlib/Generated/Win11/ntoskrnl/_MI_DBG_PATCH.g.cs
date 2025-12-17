#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _MI_DBG_PATCH
    {
        [FieldOffset(0)]
        public _unnamed_tag_ u1;
        [FieldOffset(8)]
        public _unnamed_tag_ u2;
        [FieldOffset(12)]
        public uint OriginalBytes;
        [FieldOffset(16)]
        public uint NewBytes;
        [FieldOffset(20)]
        public uint Padding;
    }
}