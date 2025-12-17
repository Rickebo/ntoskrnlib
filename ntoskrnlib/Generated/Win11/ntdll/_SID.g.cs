#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _SID
    {
        [FieldOffset(0)]
        public byte Revision;
        [FieldOffset(1)]
        public byte SubAuthorityCount;
        [FieldOffset(2)]
        public _SID_IDENTIFIER_AUTHORITY IdentifierAuthority;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public uint[] SubAuthority;
    }
}