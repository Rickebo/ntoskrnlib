#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _TOKEN_CONTROL
    {
        [FieldOffset(0)]
        public _LUID TokenId;
        [FieldOffset(8)]
        public _LUID AuthenticationId;
        [FieldOffset(16)]
        public _LUID ModifiedId;
        [FieldOffset(24)]
        public _TOKEN_SOURCE TokenSource;
    }
}