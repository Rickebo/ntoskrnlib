#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _CM_KEY_VALUE
    {
        [FieldOffset(0)]
        public ushort Signature;
        [FieldOffset(2)]
        public ushort NameLength;
        [FieldOffset(4)]
        public uint DataLength;
        [FieldOffset(8)]
        public uint Data;
        [FieldOffset(12)]
        public uint Type;
        [FieldOffset(16)]
        public ushort Flags;
        [FieldOffset(18)]
        public ushort Spare;
        [FieldOffset(20)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public short[] Name;
    }
}