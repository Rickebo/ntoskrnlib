#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _OBJECT_FOOTER
    {
        [FieldOffset(0)]
        public _HANDLE_REVOCATION_INFO HandleRevocationInfo;
        [FieldOffset(32)]
        public _OB_EXTENDED_USER_INFO ExtendedUserInfo;
    }
}