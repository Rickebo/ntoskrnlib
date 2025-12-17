#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _SEP_LOWBOX_NUMBER_MAPPING
    {
        [FieldOffset(0)]
        public _EX_PUSH_LOCK Lock;
        [FieldOffset(8)]
        public _RTL_BITMAP Bitmap;
        [FieldOffset(24)]
        public IntPtr HashTable;
        [FieldOffset(32)]
        public byte Active;
    }
}