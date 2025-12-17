#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PERIODIC_CAPTURE_STATE_GUIDS
    {
        [FieldOffset(0)]
        public ushort ProviderCount;
        [FieldOffset(8)]
        public IntPtr Providers;
    }
}