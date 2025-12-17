#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _CM_NAME_CONTROL_BLOCK
    {
        [FieldOffset(0)]
        public uint Compressed;
        [FieldOffset(0)]
        public uint RefCount;
        [FieldOffset(8)]
        public _CM_NAME_HASH NameHash;
        [FieldOffset(8)]
        public _CM_COMPONENT_HASH ConvKey;
        [FieldOffset(16)]
        public IntPtr NextHash;
        [FieldOffset(24)]
        public ushort NameLength;
        [FieldOffset(26)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public short[] Name;
    }
}