#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _MI_SUB64K_FREE_RANGES
    {
        [FieldOffset(0)]
        public _RTL_BITMAP_EX BitMap;
        [FieldOffset(16)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(32)]
        public IntPtr Vad;
        [FieldOffset(40)]
        public uint SetBits;
        [FieldOffset(44)]
        public uint FullSetBits;
        [FieldOffset(48)]
        public uint SubListIndex;
        [FieldOffset(48)]
        public uint Hint;
    }
}