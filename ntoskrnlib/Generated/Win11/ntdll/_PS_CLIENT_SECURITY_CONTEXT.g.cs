#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _PS_CLIENT_SECURITY_CONTEXT
    {
        [FieldOffset(0)]
        public ulong ImpersonationData;
        [FieldOffset(0)]
        public IntPtr ImpersonationToken;
        [FieldOffset(0)]
        public ulong ImpersonationLevel;
        [FieldOffset(0)]
        public ulong EffectiveOnly;
    }
}