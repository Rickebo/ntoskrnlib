#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _OB_HANDLE_REVOCATION_BLOCK
    {
        [FieldOffset(0)]
        public _LIST_ENTRY RevocationInfos;
        [FieldOffset(16)]
        public _EX_PUSH_LOCK Lock;
        [FieldOffset(24)]
        public _EX_RUNDOWN_REF Rundown;
    }
}