#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial struct _INITIAL_PRIVILEGE_SET
    {
        [FieldOffset(0)]
        public uint PrivilegeCount;
        [FieldOffset(4)]
        public uint Control;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public _LUID_AND_ATTRIBUTES[] Privilege;
    }
}