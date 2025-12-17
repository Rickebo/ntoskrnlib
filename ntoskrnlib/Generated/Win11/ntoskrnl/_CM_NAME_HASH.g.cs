#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _CM_NAME_HASH
    {
        [FieldOffset(0)]
        public _CM_COMPONENT_HASH ConvKey;
        [FieldOffset(8)]
        public IntPtr NextHash;
        [FieldOffset(16)]
        public ushort NameLength;
        [FieldOffset(18)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public short[] Name;
    }
}