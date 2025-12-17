#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct _PRIVILEGE_SET
    {
        [FieldOffset(0)]
        public uint PrivilegeCount;
        [FieldOffset(4)]
        public uint Control;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _LUID_AND_ATTRIBUTES[] Privilege;
    }
}