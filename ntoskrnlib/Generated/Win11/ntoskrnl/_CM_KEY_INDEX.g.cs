#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _CM_KEY_INDEX
    {
        [FieldOffset(0)]
        public ushort Signature;
        [FieldOffset(2)]
        public ushort Count;
        [FieldOffset(4)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public uint[] List;
    }
}