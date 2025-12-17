#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _MI_COMBINE_BLOCK
    {
        [FieldOffset(0)]
        public _unnamed_tag_ u1;
        [FieldOffset(24)]
        public ulong HashValue;
        [FieldOffset(32)]
        public _MMCLONE_BLOCK Clone;
        [FieldOffset(64)]
        public ulong CombineDomain;
    }
}