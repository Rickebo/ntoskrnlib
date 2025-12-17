#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _CM_KEY_SECURITY_CACHE_ENTRY
    {
        [FieldOffset(0)]
        public uint Cell;
        [FieldOffset(8)]
        public IntPtr CachedSecurity;
    }
}