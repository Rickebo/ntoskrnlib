#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _TOKEN_PRIVILEGES
    {
        [FieldOffset(0)]
        public uint PrivilegeCount;
        [FieldOffset(4)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _LUID_AND_ATTRIBUTES[] Privileges;
    }
}