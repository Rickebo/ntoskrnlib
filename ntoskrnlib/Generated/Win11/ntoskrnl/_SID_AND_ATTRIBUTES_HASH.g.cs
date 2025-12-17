#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 272)]
    public partial struct _SID_AND_ATTRIBUTES_HASH
    {
        [FieldOffset(0)]
        public uint SidCount;
        [FieldOffset(8)]
        public IntPtr SidAttr;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public ulong[] Hash;
    }
}