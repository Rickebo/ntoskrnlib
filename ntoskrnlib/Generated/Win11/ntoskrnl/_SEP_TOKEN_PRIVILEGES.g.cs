#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _SEP_TOKEN_PRIVILEGES
    {
        [FieldOffset(0)]
        public ulong Present;
        [FieldOffset(8)]
        public ulong Enabled;
        [FieldOffset(16)]
        public ulong EnabledByDefault;
    }
}