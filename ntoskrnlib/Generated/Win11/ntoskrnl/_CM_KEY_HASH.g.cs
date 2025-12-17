#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _CM_KEY_HASH
    {
        [FieldOffset(0)]
        public _CM_PATH_HASH ConvKey;
        [FieldOffset(8)]
        public IntPtr NextHash;
        [FieldOffset(16)]
        public IntPtr KeyHive;
        [FieldOffset(24)]
        public uint KeyCell;
    }
}