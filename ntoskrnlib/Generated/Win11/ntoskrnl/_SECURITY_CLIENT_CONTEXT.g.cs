#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _SECURITY_CLIENT_CONTEXT
    {
        [FieldOffset(0)]
        public _SECURITY_QUALITY_OF_SERVICE SecurityQos;
        [FieldOffset(16)]
        public IntPtr ClientToken;
        [FieldOffset(24)]
        public byte DirectlyAccessClientToken;
        [FieldOffset(25)]
        public byte DirectAccessEffectiveOnly;
        [FieldOffset(26)]
        public byte ServerIsRemote;
        [FieldOffset(28)]
        public _TOKEN_CONTROL ClientTokenControl;
    }
}