#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _GROUP_AFFINITY
    {
        [FieldOffset(0)]
        public ulong Mask;
        [FieldOffset(8)]
        public ushort Group;
        [FieldOffset(10)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public ushort[] Reserved;
    }
}