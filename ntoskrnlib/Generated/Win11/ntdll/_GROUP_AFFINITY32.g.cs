#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _GROUP_AFFINITY32
    {
        [FieldOffset(0)]
        public uint Mask;
        [FieldOffset(4)]
        public ushort Group;
        [FieldOffset(6)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public ushort[] Reserved;
    }
}